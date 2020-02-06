using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command : MonoBehaviour
{
    public abstract void Execute(Animator anim, bool forward);

}

public class MoveForward : Command
{
    public override void Execute(Animator anim, bool forward)
    {
        if (forward)
        {
            anim.SetTrigger("walk");
        }
        else
        {
            anim.SetTrigger("walkR");
        }
    }
}

public class PerformJump : Command
{
    public override void Execute(Animator anim, bool forward)
    {
        //実際は、jumpアニメではなく適当なアニメが割り当てられている
        anim.SetTrigger("jump");
    }
}

public class PerformKick : Command
{
    public override void Execute(Animator anim, bool forward)
    {
        //実際は、kickアニメではなく適当なアニメが割り当てられている
        anim.SetTrigger("kick");
    }
}

public class PerformPunch : Command
{
    public override void Execute(Animator anim, bool forward)
    {
        //実際は、punchアニメではなく適当なアニメが割り当てられている
        anim.SetTrigger("punch");
    }
}

public class DoNothing : Command
{
    public override void Execute(Animator anim, bool forward)
    {
        
    }
}

