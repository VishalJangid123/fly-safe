using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{

    [SerializeField] private GameObject[] obstacles;

    public float minX;
    public float minY;
    public float maxX;
    public float maxY;

    public float timeBetweenSpawn;
    public float spawnTime;

    void Update()
    {
        if (Player.startGame == false) return;

        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
        
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        GameObject randomObstacle = obstacles[Random.Range(0, obstacles.Length)];

        Instantiate(randomObstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
