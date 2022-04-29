using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    public int currenthealth = 50;

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

    void playerDie()
    {
        Debug.Log("Player died");
        animator.SetBool("isDead", true);
    }

 public void playerDamage(int damage)
    {
        currenthealth -= damage;
        health.playerHealth(currenthealth);

        if (currenthealth <= 0)
        {
            playerDie();
        }
    }

    public void increaseHealth(int increase)
    {
        currenthealth += increase;

        if (currenthealth > maxHealth)
        {
            currenthealth = maxHealth;
        }
    }
}
