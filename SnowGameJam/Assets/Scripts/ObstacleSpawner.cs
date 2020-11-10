using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public Transform[] spawnLocations;
    public GameObject[] obstaclesToSpawn;
    public float spawnInterval = 1f;

    private float timeToSpawn = 2f;
    // Start is called before the first frame update
    void Start()
    {


   
    }

    void SpawnObstacles() {
        int randomLocation = Random.Range(0, spawnLocations.Length);
        int randomObstacle = Random.Range(0, obstaclesToSpawn.Length);

        for (int i = 0; i < spawnLocations.Length; i++) {
            if (randomLocation == i) {
                Instantiate(obstaclesToSpawn[randomObstacle], spawnLocations[i].position, Quaternion.identity);
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToSpawn) {
            SpawnObstacles();
            timeToSpawn = Time.time + spawnInterval;
        }


        
    }
}
