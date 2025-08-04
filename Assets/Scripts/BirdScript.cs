using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public bool birdIsAlive = true;
    public LogicScript logic;
    public float deadZone = -20f;

    [SerializeField] private Animator animator;


    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    void Update()
    {
        BirdMovement();
        Deadzone();
    }

    void BirdMovement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;

            animator.SetBool("isFlying", true);

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.down * flapStrength;

            animator.SetBool("isFlying", true);

        }
        else
        {
            animator.SetBool("isFlying", false);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
    }

    void Deadzone()
    {
        if (transform.position.y < deadZone)
        {
            logic.GameOver();
            birdIsAlive = false;
        }
    }


}
