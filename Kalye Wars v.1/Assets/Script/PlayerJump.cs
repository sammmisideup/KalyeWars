using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rb;
    public Animator animator;
    [SerializeField] int jumpPower;

    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        isGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(8f, 0.7f), CapsuleDirection2D.Horizontal, 0, groundLayer);
        

        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            animator.SetBool("IsJumping", true);
        }
        if (Input.GetKey(KeyCode.S) && isGrounded)
        {
            animator.SetBool("IsDodge", true);
        }
        
    }
    
    
}
