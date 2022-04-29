using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInventory : MonoBehaviour
{
    public int keyCount = 0;

    public void keyFound(int increase)
    {
        keyCount += increase;
        Debug.Log("No. of Keys: " + keyCount);
    }
}
