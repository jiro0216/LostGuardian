//using Unity.VisualScripting;
//using UnityEditor.Rendering;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    [Header("Cloud")]
    public GameObject[] cloudPrefabs;


    [Header("Spawn Timing")]
    public float spawnRate = 2f;      // Time between spawns (in seconds)
    public int minRate = 1;   // Minimum number of clouds per spawn
    public int maxRate = 3;   // Maximum number of clouds per spawn
    private float timer = 0f;

    [Header("Spawn Area (Y Range)")]
    public float lowestPoint;   // Minimum Y position
    public float highestPoint;   // Maximum Y position

    [Header("Offset Range")]
    public float xOffsetMin = -4f;
    public float xOffsetMax = 4f;
    public float yJitter = 0.5f; // Small vertical randomness


    [Header("Cloud Spawn Amount")]
    public int minClouds = 1;   // Minimum number of clouds per spawn
    public int maxClouds = 3;   // Maximum number of clouds per spawn


    [Header("Debug")]
    public int pipeCount = 0;



    void Update()
    {

        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnCloud();
            timer = 0;
            spawnRate = GetRandomSpawnRate();

        }

    }

    float GetRandomSpawnRate()
    {
        return Random.Range(minRate, maxRate);


    }

    void SpawnCloud()
    {

        int spawnCount = Random.Range(minClouds, maxClouds + 1); // Random between min and max (inclusive)

        for (int i = 0; i < spawnCount; i++)
        {
            float randomY = Random.Range(lowestPoint, highestPoint);
            float randomYOffset = Random.Range(-yJitter, yJitter);
            float randomXOffset = Random.Range(xOffsetMin, xOffsetMax);

            // Choose a random prefab
            GameObject selectedCloud = cloudPrefabs[Random.Range(0, cloudPrefabs.Length)];

            Vector3 spawnPos = new Vector3(transform.position.x + randomXOffset, randomY + randomYOffset, 0f);

            Instantiate(selectedCloud, spawnPos, transform.rotation);
            pipeCount++;
        }


        Debug.Log("Clouds Spawned: " + spawnCount + " | Total Spawned: " + pipeCount + " | SpawnRate" + spawnRate);

    }





}
