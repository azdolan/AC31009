using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    private int currentHealth;
    public PlayerScore score;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void Damage(int enemyDamage)
    {
        currentHealth -= enemyDamage;

        //play hurt animation

        if(currentHealth <= 0)
        {
            enemyDie();
            
        }
    }

    void enemyDie()
    {
        Debug.Log("Enemy died");
        // die animation
        animator.SetBool("IsDead", true);
        score.player += 10;

        // disable enemy
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
    
}
