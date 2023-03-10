using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunSpawn : MonoBehaviour
{
    public GameObject prefab;

    // Use this for initialization
    void Start()
    {
        // Spawn first Sun in 10 seconds, repeat every 10 seconds
        InvokeRepeating("Spawn", 5, 5);
    }

    void Spawn()
    {
        // Load prefab into the Scene
        // -> transform.position means current position
        // -> Quaternion.identity means default rotation
        Instantiate(prefab,
                    transform.position,
                    Quaternion.identity);
    }
}