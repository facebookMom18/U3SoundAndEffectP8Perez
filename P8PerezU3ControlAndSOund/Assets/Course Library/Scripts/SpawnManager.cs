using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    public GameObject[] obstaclePrefabs;

    private float repeatRate = 2;
    private float startDelay = 2;
    private int randomObstacle;
    private PlayerController playerControllerScript;
   
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = 
            GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            randomObstacle = Random.Range(0, obstaclePrefabs.Length);
            Instantiate(obstaclePrefabs[randomObstacle], spawnPos, obstaclePrefabs[randomObstacle].transform.rotation);
        }
    }

  
    void Update()
    {
        
    }
}
