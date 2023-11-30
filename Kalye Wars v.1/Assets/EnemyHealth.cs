using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float Health;
    public float maxHealth;
    public Image EHB;
    public float delayTime = .15f;
    public AIMovement Enemymovement;

    
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = Health;
    }

    // Update is called once per frame
    void Update()
    {
        EHB.fillAmount = Mathf.Clamp(Health/maxHealth, 0, 1);
    }

    public void TakeDamage(float damage)
    {   
        Health -= damage;
        StartCoroutine(KnockbackDelay());
    }



    IEnumerator KnockbackDelay()
    {
        Enemymovement.enabled = false;
        yield return new WaitForSeconds(delayTime);
        if (Health <=0 )
        {
            Destroy(gameObject);
        }
        else
        {
            Enemymovement.enabled = true;
        }
    }
   
}
