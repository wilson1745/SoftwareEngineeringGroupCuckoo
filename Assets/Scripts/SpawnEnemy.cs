using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    public GameObject[] prefab;
    private float firstEnemy, others;
    public static float spawnPeriod = 10f;
    int temp = -1;

    void Start () {
        firstEnemy = spawnPeriod;
        others = spawnPeriod;
        // Spawn first Sun in X seconds, repeat every X seconds
        InvokeRepeating("ZSpawn", firstEnemy, others);
    }

    void ZSpawn()
    {
        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        do {
            spawnPointIndex = Random.Range(0, spawnPoints.Length);
        } while (temp == spawnPointIndex);
        temp = spawnPointIndex;
        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Quaternion reverse = spawnPoints[spawnPointIndex].rotation;
        if (prefab[0].name == "whitecatattack")
        {
            reverse = new Quaternion(0, -180, 0, 0);
        }
        Instantiate(prefab[0], spawnPoints[spawnPointIndex].position, reverse);
    }
}
