using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefabs;
    private float spawnRangeX = 15;
    private float spawnRangeZ = 12;

    private float startDelay = 2;
    private float repeatRate = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, repeatRate);
    }

    private void Update()
    {
    }
    
    private void SpawnRandomEnemy()
    {
        //int animalIndex = Random.Range(0,enemyPrefabs);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, spawnRangeZ);
            
        Instantiate(enemyPrefabs, spawnPos ,enemyPrefabs.transform.rotation);
    }
}
