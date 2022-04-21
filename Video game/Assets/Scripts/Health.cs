using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public Slider slider;


    /*
     * This function will set the max health 
     */

    public void maxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }


    /*
     * this function sets the health on the slider 
     */

    public void playerHealth(int health)
    {
        slider.value = health;
    }


}

