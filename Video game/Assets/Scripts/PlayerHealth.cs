using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currenthealth;

    public Health health;


     void Start()
    {
        currenthealth = maxHealth;
        health.maxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            playerDamage(20);
        }
    }

  void playerDamage(int damage)
    {
        currenthealth -= damage;
        health.playerHealth(currenthealth);
    }

}
