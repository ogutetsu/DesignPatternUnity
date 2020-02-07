using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class UggGameEnvironment
{
    private static UggGameEnvironment instance;
    private List<GameObject> checkpoints = new List<GameObject>();
    public List<GameObject> Checkpoints
    {
        get { return checkpoints; }
    }

    public static UggGameEnvironment Singleton
    {
        get
        {
            if (instance == null)
            {
                instance = new UggGameEnvironment();
                instance.Checkpoints.AddRange(GameObject.FindGameObjectsWithTag("Checkpoint"));
            }
            return instance;
        }
    }


}
