using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Health : MonoBehaviour
{
    public Slider slider; // allows me to access the slider component for player health 

    public void playerStartingHealth(int health)
    {
        slider.value = health;
    }

    public void playerMaxHealth(int health)
    {
        //slider.maxValue = health;
        slider.value = health;
    }
}
