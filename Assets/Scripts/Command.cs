using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command : MonoBehaviour
{
    public abstract void Execute(Animator anim);

}

public class PerformJump : Command
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("jump");
    }
}

public class DoNothing : Command
{
    public override void Execute(Animator anim)
    {
        
    }
}

