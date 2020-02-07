using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceMove : MonoBehaviour
{
    public Vector3 velocity;

   
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(velocity);
    }
}
