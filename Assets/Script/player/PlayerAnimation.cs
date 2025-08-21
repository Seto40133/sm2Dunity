using UnityEngine;
 
public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
 
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 左右移動の速度（絶対値）を取得してSpeedに渡す
        float speed = Mathf.Abs(Input.GetAxis("Horizontal"));
        animator.SetFloat("Speed", speed);

        // ジャンプ中かどうかを判定（上下方向の速度で判断）
        bool isJumping = Mathf.Abs(rb.velocity.y) > 0.1f;

        animator.SetBool("IsJumping", isJumping);
        
        
    }
}