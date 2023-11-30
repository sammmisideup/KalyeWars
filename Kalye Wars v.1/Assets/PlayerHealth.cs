using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float Health;
    public float maxHealth;
    public Image HB;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = Health;
    }

    // Update is called once per frame
    void Update()
    {
        HB.fillAmount = Mathf.Clamp(Health / maxHealth, 0 , 1);
    }
}
