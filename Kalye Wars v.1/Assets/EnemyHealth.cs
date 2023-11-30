using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour
{
    public float EHealth;
    public float maxHealth;
    public Image EHB;
    public Animator animator;
    AIMovement aiMovement;
    EnemyAttack enemyAttack;

    // Start is called before the first frame update
    void Start()
    {
        aiMovement = gameObject.GetComponent<AIMovement>();
        enemyAttack = gameObject.GetComponent<EnemyAttack>();
        maxHealth = EHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        EHB.fillAmount = Mathf.Clamp(EHealth/maxHealth, 0, 1);

        if (EHealth <= 0)
        {
            animator.SetBool("KO", true);
            aiMovement.enabled = false;
            enemyAttack.enabled = false;
        }
    }
        

   
}
