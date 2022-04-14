using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    public Animator animator;

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) //if the player presses the E button
        {
            openDoor(); //This makes the openDoor function happen
        }
    }

    /*
     * This function will make the door animation play when certain events in the game are triggered 
     * 
     */

    public void openDoor()
    {
        animator.SetTrigger("DoorOpen"); // this makes the door animation play
        Debug.Log("Door is open"); // for testing purposes to see if the animation plays
    }

}
