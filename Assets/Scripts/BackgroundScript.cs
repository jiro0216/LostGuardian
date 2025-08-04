using UnityEngine;

public class BackgroundScript : MonoBehaviour
{

    public float moveSpeed;
    public float deadZone = -40f;


    void Update()
    {

        Deadzone();
        BackgroundMovement();


    }

    void BackgroundMovement()
    {

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

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
