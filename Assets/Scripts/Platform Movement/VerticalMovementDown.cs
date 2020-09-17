﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovementDown : MonoBehaviour
{
    //This script makes the platform move down.
    private Vector3 pos1;
    private Vector3 pos2;


    public float speed = 1f;


    // Start is called before the first frame update
    private void Start()
    {
        pos1 = transform.position;
        pos2 = pos1;
        pos2.y = pos1.y - 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}