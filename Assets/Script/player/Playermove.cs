using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Playermove : MonoBehaviour
{

    [SerializeField] private float movespeed = 5f;

    [SerializeField] private float jumpSpeed = 10f;

    [SerializeField] private Transform groundCheck;

    [SerializeField] private LayerMask groundLayer;

    private Rigidbody2D rd;

    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        rd.velocity = new Vector2(move * movespeed, rd.velocity.y);

        if (move != 0)
        {
            Vector3 scale = transform.localScale;
            scale.x = Mathf.Abs(scale.x) * Mathf.Sign(move);
            transform.localScale = scale;
        }
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rd.velocity = new Vector2(rd.velocity.x, jumpSpeed);
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


