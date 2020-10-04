using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsMonitor : MonoBehaviour
{
    public GameObject WinText;
    public static int coinsCounter=0;
    void Update()
    {
        if (coinsCounter == 3)
        {
            WinText.SetActive(true);
        }
    }
}
