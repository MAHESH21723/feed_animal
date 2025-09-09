using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
   

    private float spawnLimitXLeft = -20;
    private float spawnLimitXRight = 6;
    private float spawnPosY = 29;
    private float startDelay = 1.0f;
    private float spawnInterval = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }
    void Update()
    {
        
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 2.5f);
        int balllindex = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location ball index declaration
        Instantiate(ballPrefabs[balllindex], spawnPos, ballPrefabs[balllindex].transform.rotation);
    }

}
