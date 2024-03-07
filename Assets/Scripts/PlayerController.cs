using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 5f;        // Movement speed
    public float jumpForce = 10f;       // Jump force
    public float groundCheckDistance = 0.1f;   // Distance to check if the player is grounded
    public LayerMask groundLayer;       // LayerMask for detecting ground

    private Rigidbody rb;               // Reference to the Rigidbody component
    private bool isGrounded;            // Flag to check if the player is grounded

    void Start() {
        // Get the Rigidbody component attached to the player
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        // Check if the player is grounded
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundLayer);

        // Get input for movement
        float moveInputX = Input.GetAxis("Horizontal");
        float moveInputZ = Input.GetAxis("Vertical");

        // Move the player horizontally
        Vector3 moveDirection = new Vector3(moveInputX, 0f, moveInputZ) * moveSpeed;
        rb.velocity = new Vector3(moveDirection.x, rb.velocity.y, moveDirection.z);

        if (Input.GetButtonDown("Jump") && isGrounded) {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
    }
}
