using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    private PlayerController playerControllerScript;

    private float startDelay;
    private float repeatRate;

    void Start()
    {
        startDelay = 1f;
        repeatRate = 3f;
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
