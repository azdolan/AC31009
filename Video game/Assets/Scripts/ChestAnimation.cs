using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestAnimation : MonoBehaviour
{
    public Animator animator;

    
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            openChest();
        }
    }
    

   public void openChest()
    {
        animator.SetTrigger("OpenChest");
        Debug.Log("Chest opened");
    }
}

