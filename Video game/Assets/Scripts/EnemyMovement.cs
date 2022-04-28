using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float characterMovement;
    public float rayDistance;
    bool rightDirection = true;
    public Transform endofRoute;
    public LayerMask groundLayer;

   void Start()
    {
        if(this.gameObject.name == "enemy")
        {
            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
    void Update()
    {
        moveEnemy();
       
    }

    

    void moveEnemy()
    {
        
        transform.Translate(Vector2.right * characterMovement * Time.deltaTime);

        RaycastHit2D bottom = Physics2D.Raycast(endofRoute.position, Vector2.down, rayDistance);

        //if the Raycast has not collided with anything 
        if (bottom.collider == false)
        {
            Debug.Log("Collider: " + this.gameObject.name);
            //if the character is moving right
            if (rightDirection == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0); // turns the character around the face the other direction
                rightDirection = false;


            }
            // if the character is moving in the left direction
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                rightDirection = true;
            }

        }
        /*
            else
            {
                Debug.Log("collider name: " + right.collider.name);
            }
        */


    }
    
}


