using System.Threading;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    [Header("Pipe Settings")]
    public GameObject[] obstaclePrefabs;

    [Header("Spawn Timing")]
    public float spawnRate = 2f;      // Time between spawns (in seconds)
    private float timer = 0f;

    [Header("Spawn Area (Y Range)")]
    public float lowestPoint;   // Minimum Y position
    public float highestPoint;   // Maximum Y position

    [Header("Debug")]
    public int pipeCount = 0;         // Total number of pipes spawned

    void Update()
    {

        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {

        GameObject selectedObstacle = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];

        pipeCount++;

        Instantiate(selectedObstacle, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        Debug.Log("PipeSpawn");
        Debug.Log("PipeSpawned: " + pipeCount);
    }
}
