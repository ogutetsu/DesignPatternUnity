using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceMove : MonoBehaviour
{
    public Vector3 velocity;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "asteroid")
        {
            Destroy(collision.gameObject);
        }
    }
   
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(velocity);
    }
}
