using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    public Animator animator;
    public Transform doorPoint;
    public float doorRange;
    public LayerMask doorLayer;

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
            doorTrigger();
            Debug.Log("Test to see if door trigger is opened");
              
        }


    }

    public void doorTrigger()
    {
        
        

        Collider2D[] doors = Physics2D.OverlapCircleAll(doorPoint.position, doorRange, doorLayer);
        Debug.Log(doorPoint.position + " " + doorRange + " " + doorLayer);
        Debug.Log("Number of doors in range" + doors.Length);

        foreach (Collider2D door in doors) // this loops for every item stored in the enemiesHit array
        {
            animator.SetTrigger("DoorOpen"); // this makes the door animation play
            Debug.Log("Door is open"); // for testing purposes to see if the animation plays

            

        }


    }
    void OnDrawGizmosSelected()
    {
        if (doorPoint == null)
        {
            return;
        }

        // this draws a sphere on the editor which makes it easiser for me to visulaise how the player attacks the enemy
        Gizmos.DrawWireSphere(doorPoint.position, doorRange);

    }
}
