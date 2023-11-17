using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject player;
    public float distanceBetween;
    private float distance;
    public Animator animator;
    AIMovement AiMovement;
    // Start is called before the first frame update
    void Start()
    {
        AiMovement = gameObject.GetComponent<AIMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();

        if (distance < distanceBetween)
        {
            animator.SetTrigger("MiddleAttack");
            AiMovement.enabled = false;
           
        }
        else if (distance > distanceBetween)
        {
            AiMovement.enabled = true;
        }

    }
}
