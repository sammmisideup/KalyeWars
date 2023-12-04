using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float Health;
    public float maxHealth;
    public Image HB;
    public Animator animator;
   // public EnemyAttack enemyAttack;


    // Start is called before the first frame update
    void Start()
    {
        maxHealth = Health;
        //enemyAttack = gameObject.GetComponent<EnemyAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        HB.fillAmount = Mathf.Clamp(Health / maxHealth, 0 , 1);

        if (Health <= 0)
        {
            animator.SetBool("K.O", true);
            //enemyAttack.enabled = false;
        }
    }
}
