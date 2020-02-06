using System.ComponentModel;
using Unity.Entities;
using Unity.Burst;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

public class SpawnerSystem : JobComponentSystem
{
    private EndSimulationEntityCommandBufferSystem mEntityCommandBufferSystem;

    protected override void OnCreateManager()
    {
        mEntityCommandBufferSystem = World.GetOrCreateSystem<EndSimulationEntityCommandBufferSystem>();
    }

    struct SpawnJob : IJobForEachWithEntity<Spawner, LocalToWorld>
    {
        public EntityCommandBuffer CommandBuffer;

        public void Execute(Entity entity, int index, ref Spawner spaner,
            ref LocalToWorld location)
        {
            for (int x = 0; x < spaner.Erows; x++)
            {
                for (int z = 0; z < spaner.Ecols; z++)
                {
                    var instance = CommandBuffer.Instantiate(spaner.Prefab);
                    var pos = math.transform(location.Value,
                        new float3(x, noise.cnoise(new float2(x, z) * 0.21f), z));
                    CommandBuffer.SetComponent(instance, new Translation { Value = pos });
                }
            }
            CommandBuffer.DestroyEntity(entity);
        }
    }

    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        var job = new SpawnJob
        {
            CommandBuffer = mEntityCommandBufferSystem.CreateCommandBuffer()
        }.ScheduleSingle(this, inputDeps);

        mEntityCommandBufferSystem.AddJobHandleForProducer(job);
        return job;
    }

}
