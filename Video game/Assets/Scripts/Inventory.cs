using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int keyCount = 0;

    public void keyFound(int increase)
    {
        keyCount += increase;
    }
}
