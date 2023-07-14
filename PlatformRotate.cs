using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotate : MonoBehaviour
{
    public Vector3 rotateChange;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(rotateChange);
    }
}
