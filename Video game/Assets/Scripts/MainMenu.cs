using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /*
     * This function will load the game from the beginning when the player clicks on the start game button
     */

    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }

    /*
     * this function will quit the game when the player 
     */
    public void quitGame()
    {

        Application.Quit();
        Debug.Log("this is a test to see if it works"); //debug log to test that it works
    }
}
