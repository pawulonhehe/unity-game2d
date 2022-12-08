using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public GameObject[] spawns;
    public float spawnTime = 1f;
    public float spawnDelay = 1f;

    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    void Spawn()
    {
        int prefabIndex = Random.Range(0, prefabs.Length);
        int spawnIndex = Random.Range(0, 20);
        Instantiate(prefabs[prefabIndex], spawns[spawnIndex].transform.position, Quaternion.identity);
    
    }
}
