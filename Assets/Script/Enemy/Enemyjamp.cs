using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class JumpEnemyRigidbody : MonoBehaviour
{
    public float jumpForce = 5f;       
    public float jumpInterval = 2f;    
    public LayerMask groundLayer;      
    public Transform groundCheck;      

    private Rigidbody2D rb;
    private float jumpTimer = 0f;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 1f;          
    }

    void Update()
    {
        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        jumpTimer += Time.deltaTime;

        if (jumpTimer >= jumpInterval && isGrounded)
        {
            jumpTimer = 0f;
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(groundCheck.position, 0.1f);
        }
    }
}
