using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>Creating Timer to start once reaches the flag</summary>
public class WinTrigger : MonoBehaviour
{
    public Text TimerText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Timer.instance.EndTimer();
            TimerText.fontSize = 80;
            TimerText.color= Color.green;
        }
    }
}