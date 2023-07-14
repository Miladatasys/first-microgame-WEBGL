using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using System.Collections.Specialized
using System;

public class BallTransform : MonoBehaviour
{
    public Vector3 scaleChange;
    public int deltaMs = 1000;

    private long mark;
    // Start is called before the first frame update
    void Start()
    {
        mark = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        long newMark = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        if (newMark - mark >= deltaMs)
        {
            mark = newMark;
            transform.localScale += scaleChange;
        }
    }
}



