using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator animator;


    /** 
     * Void Update() allows the main character to move 
     */

    void Update()
    {
        Vector3 characterMovement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        animator.SetFloat("Horizontal", characterMovement.x);
        animator.SetFloat("Vertical", characterMovement.y);
        animator.SetFloat("Magnitude", characterMovement.magnitude);
        
        transform.position = transform.position + characterMovement * Time.deltaTime;
    }
}
