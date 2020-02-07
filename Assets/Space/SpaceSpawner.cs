﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceSpawner : MonoBehaviour
{
    public GameObject asteroid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 100) < 5)
        {
            //Instantiate(asteroid,
            //    this.transform.position +
            //    new Vector3(Random.Range(-10, 10), 0, 0), Quaternion.identity);

            GameObject a = Pool.singleton.Get("asteroid");
            if (a != null)
            {
                a.transform.position = this.transform.position + 
                                       new Vector3(Random.Range(-10, 10), 0, 0);
                a.SetActive(true);
            }
        }
    }

}
