using UnityEngine;

public class ParallaxScript : MonoBehaviour
{


    public GameObject background;

    public float spawnRate = 2;

    private float timer = 0;

    void Start()
    {
        SpawnBackground();
    }


    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnBackground();
            timer = 0;
        }


    }

    void SpawnBackground()
    {

        Instantiate(background, transform.position, transform.rotation);

    }
}
