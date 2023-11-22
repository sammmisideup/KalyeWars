using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    Rigidbody2D rb;
    int attackIndex;
    [SerializeField] int jumpPower;
    public GameObject player;
    public float distanceBetween;
    private float distance;
    private float timer;
    public Animator animator;

    
    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGrounded;

    AIMovement AiMovement;
    // Start is called before the first frame update
    void Start()
    {
        AiMovement = gameObject.GetComponent<AIMovement>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();

        isGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(8f, 0.7f), CapsuleDirection2D.Horizontal, 0, groundLayer);
       
        
        if (distance < distanceBetween && (timer <= 0))
        {   
            
            //yield return new WaitForSeconds(1);
            timer = 1f;
            attackIndex = Random.Range(0, 5);
            animator.SetInteger("AttackIndex", Random.Range(0, 7));
            animator.SetTrigger("Attack");
            AiMovement.enabled = false;
            //rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            
        }

        if (attackIndex == 3 && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
      
        else
        {
            timer -= Time.deltaTime;
            attackIndex = 0;
        }

        if (distance > distanceBetween)
        {
            AiMovement.enabled = true;
        }

    }
}
