using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 2f;

    public GameObject[] obstaclePrefabs;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);
    private PlayerControl playerControlScript;
    // Start is called before the first frame update
    void Start()
    {
        float repeatRate = Random.Range(1.1f, 1.8f);

        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControlScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        if (playerControlScript.gameOver == false)
        {
            Instantiate(obstaclePrefabs[obstacleIndex], spawnPosition, obstaclePrefabs[obstacleIndex].transform.rotation);
        }
    }
}
