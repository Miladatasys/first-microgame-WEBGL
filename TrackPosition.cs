using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using System.Collections.Specialized
using System;


public class TrackPosition : MonoBehaviour
{
    public Vector3 positionChange;

    void Start()
    {

    }

    void Update()
    {
        transform.position += positionChange;
    }
}

