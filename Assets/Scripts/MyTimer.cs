using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTimer : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // Spawn first Sun in 10 seconds, repeat every 10 seconds
        InvokeRepeating("Spawn", 1, 1);
    }

    void Spawn()
    {
        level.times++;
    }
}