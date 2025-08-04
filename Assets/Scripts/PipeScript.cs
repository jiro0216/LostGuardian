using UnityEngine;

public class PipeScript : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;

    [Header("Despawn Settings")]
    public float deadZone = -20f;

    void Update()
    {
        PipeMovement();
        Deadzone();
    }

    void PipeMovement()
    {


        transform.position += Vector3.left * moveSpeed * Time.deltaTime;


    }

    void Deadzone()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
            Debug.Log("Pipe Deleted");
        }
    }
}
