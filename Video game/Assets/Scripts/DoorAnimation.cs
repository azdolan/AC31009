using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    public Animator animator;
    

    public void Update()
    {
        openDoor();
    }

    /*
     * This function will make the door animation play when certain events in the game are triggered 
     * 
     */

    public void openDoor()
    {
        if (Input.GetKeyDown(KeyCode.E))
      {
            animator.SetTrigger("DoorOpen"); // this makes the door animation play
            Debug.Log("Door is open"); // for testing purposes to see if the animation plays   
       }
        
       
    }
    
}
