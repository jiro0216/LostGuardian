using UnityEngine;

public class CoinScript : MonoBehaviour
{

    [Header("Movement Settings")]
    public float moveSpeed = 5f;

    [Header("Despawn Settings")]
    public float deadZone = -20f;


    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        CoinMovement();
        Deadzone();
    }

    void CoinMovement()
    {

        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.AddCoin(1);
            Destroy(gameObject);
            Debug.Log("Coin Deleted");

        }

    }


    void Deadzone()
    {
        if (transform.position.x < deadZone)
        {

            Destroy(gameObject);
            Debug.Log("Cloud Deleted");

        }
    }



}
