﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyKulaFlyg : MonoBehaviour
{

    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.up * Time.fixedDeltaTime * bulletSpeed;
    }
}
