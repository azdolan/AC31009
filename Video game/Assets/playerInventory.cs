using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInventory : MonoBehaviour
{
    public int keyCount;

    public void keyFound()
    {
        keyCount++;
        Debug.Log("No. of Keys: " + keyCount);
    }
}
