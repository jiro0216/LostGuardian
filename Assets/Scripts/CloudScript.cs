using UnityEngine;

public class CloudScript : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;

    [Header("Despawn Settings")]
    public float deadZone = -20f;

    void Update()
    {
        CloudMovement();
        Deadzone();
    }

    void CloudMovement()
    {

        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

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
