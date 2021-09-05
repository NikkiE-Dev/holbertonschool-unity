using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float spinspeed = 45f;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(spinspeed * Time.deltaTime, 0, 0);
    }
}