﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceDrive : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject bullet;

    void Update()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        transform.Translate(translation, 0, 0);

        if (Input.GetKeyDown("space"))
        {
            Instantiate(bullet, this.transform.position, Quaternion.identity);
        }

    }
}