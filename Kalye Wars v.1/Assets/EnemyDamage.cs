using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerHealth playerHP;
    public float damage;
    public float Knockback = 10;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerHP.Health -= damage;
        }

         if (collision.gameObject.GetComponent<EnemyHealth>())
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * Knockback, ForceMode2D.Impulse);
            
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage);
        }
    }


}
