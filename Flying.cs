﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{

    public float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.x = position.x + speed * Time.deltaTime;
        transform.position = position;
    }
}
