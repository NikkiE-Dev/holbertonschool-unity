using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>Creating Timer to start once begins movement</summary>
public class TimerTrigger : MonoBehaviour
{
    public Text TimerText;
    void OnTriggerExit(Collider other)
    {
        if (Timer.instance.timerGoing == false)
        {
            Timer.instance.BeginTimer();
            TimerText.color= Color.white;
        }

    }
}