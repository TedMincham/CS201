using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    public float climbSpeed = 3f;
    

    private Rigidbody rb;
    private bool isGrounded = false;
    private bool isClimbable = false;
    private bool isClimbing = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!isClimbing) // Regular movement only when not climbing
        {
            Move();
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                Jump();
            }
        }

        if (isClimbable && Input.GetKey(KeyCode.C)) // Climb with the "C" key
        {
            StartClimbing();
        }

        if (isClimbing)
        {
            Climb();
            if (Input.GetKeyUp(KeyCode.C)) // Stop climbing when key is released
            {
                StopClimbing();
            }
        }
    }

    void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.MovePosition(transform.position + movement * moveSpeed * Time.deltaTime);
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    void StartClimbing()
    {
        isClimbing = true;
        rb.useGravity = false; // Disable gravity while climbing
        rb.velocity = Vector3.zero; // Reset velocity to prevent unintended motion
    }


    void Climb()
    {
        float verticalMove = Input.GetAxis("Vertical");
        Vector3 climbMovement = new Vector3(0, verticalMove * climbSpeed, 0);

        // Update position directly for climbing
        rb.velocity = climbMovement;
    }

    void StopClimbing()
    {
        isClimbing = false;
        rb.useGravity = true; // Re-enable gravity when climbing stops
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Climbable"))
        {
            isClimbable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Climbable"))
        {
            isClimbable = false;
            if (isClimbing) // Stop climbing if the player leaves the climbable area
            {
                StopClimbing();
            }
        }
    }
}
