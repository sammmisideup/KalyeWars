using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private int num;
    private int i;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            animator.SetTrigger("MiddlePunch");
            num++;

            if (num > 1) 
            {
            animator.SetTrigger("MiddlePunch");
            num++;
            }
            if (num > 3)
            {
            animator.SetTrigger("UpperPunch");
            num = 0;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            animator.SetTrigger("LowKick");
            i++;

            if (i > 1) 
            {
            animator.SetTrigger("LowKick");
            i++;
            }
            if (i > 3)
            {
            animator.SetTrigger("MiddleKick");
            i = 0;
            }
        }

    }
}
