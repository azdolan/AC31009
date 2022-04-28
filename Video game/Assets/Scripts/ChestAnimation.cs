using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestAnimation : MonoBehaviour
{
    public Animator animator;
    public Transform chestPoint;
    public float chestRange;
    public LayerMask chestLayer;
    


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            chestTrigger();
        }
    }
    

    public void chestTrigger()
    {

        Collider2D[] chests = Physics2D.OverlapCircleAll(chestPoint.position, chestRange, chestLayer);
        Debug.Log("Number of chests in range" + chests.Length);

        foreach (Collider2D chest in chests) // this loops for every item stored in the enemiesHit array
        {
            animator.SetTrigger("OpenChest"); //plays the chest opening animation
            chest.GetComponent<playerInventory>().keyFound();
            Debug.Log("Chest opened"); //prints to the log if triggered for testing
          

        }
    }

    void OnDrawGizmosSelected()
    {
        if (chestPoint == null)
        {
            return;
        }

        // this draws a sphere on the editor which makes it easiser for me to visulaise how the player attacks the enemy
        Gizmos.DrawWireSphere(chestPoint.position, chestRange);

    }
}

