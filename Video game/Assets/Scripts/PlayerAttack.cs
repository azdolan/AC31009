using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // if the spacebar is pressed
        {
            Attack(); //calls the attack function
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");

    }
}
