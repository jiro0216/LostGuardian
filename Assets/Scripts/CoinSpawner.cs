using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    [Header("Coin Settings")]
    public GameObject[] coinPrefabs;

    [Header("Spawn Timing")]
    public float spawnRate = 2f;      // Time between spawns (in seconds)
    private float timer = 0f;

    [Header("Spawn Area (Y Range)")]
    public float lowestPoint;   // Minimum Y position
    public float highestPoint;   // Maximum Y position

    [Header("Debug")]
    public int coinCount = 0;         // Total number of pipes spawned

    void Update()
    {

        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnCoin();
            timer = 0;
        }
    }

    void SpawnCoin()
    {

        coinCount++;

        GameObject selectedCoin = coinPrefabs[Random.Range(0, coinPrefabs.Length)];

        Instantiate(selectedCoin, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

        Debug.Log("CoinSpawn");
        Debug.Log("CoinSpawned: " + coinCount);

    }
}
