using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float enemyXRange;

    private float startDelay = 2f;
    private float repeatRate = 3f;
    private void Start()
    {
        enemyXRange = FindObjectOfType<PlayerController>().xRange;
        InvokeRepeating("SpawnEnemy",startDelay, repeatRate);
    }

    void SpawnEnemy()
    {
        
        Vector3 spawnPos = new Vector3(Random.Range(-enemyXRange,enemyXRange),1,15);

        Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
        
        
    }
}
