using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int player;
    Text score;

    // Start is called before the first frame update
   public void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    public void Update()
    {
        score.text = "Score " + player;
    }
}
