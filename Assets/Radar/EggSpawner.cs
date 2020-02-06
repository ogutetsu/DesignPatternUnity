﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{

    public GameObject eggPrefab;
    public Terrain terrain;
    private TerrainData terrainData;
    public EggEvent eggDrop;

    // Start is called before the first frame update
    void Start()
    {
        terrainData = terrain.terrainData;
        InvokeRepeating("CreateEgg", 1, 0.1f);
    }

    void CreateEgg()
    {
        int x = (int) Random.Range(0, terrainData.size.x);
        int z = (int) Random.Range(0, terrainData.size.z);
        Vector3 pos = new Vector3(x, 0, z);
        pos.y = terrain.SampleHeight(pos) + 10;
        GameObject egg = Instantiate(eggPrefab, pos, Quaternion.identity);
        eggDrop.Occurred(egg);

    }

}
