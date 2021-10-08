using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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