using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 6f; // Force added to jump
    public float spawnXPosition = -10f;
    public float spawnYPosition = 1f;
    private bool isGrounded; // Check if player is on the ground
    private Rigidbody2D rb;
    private GameManager gameManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 spawnPosition = new(spawnXPosition, spawnYPosition);
        transform.position = spawnPosition;

        gameManager = FindAnyObjectByType<GameManager>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            rb.linearVelocity = new Vector2(0, jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.collider.CompareTag("Obstacle"))
        {
            gameManager.GameOver();
        }

        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
