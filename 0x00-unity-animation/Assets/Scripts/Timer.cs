using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>Creating Timer for active gameplay</summary>
public class Timer : MonoBehaviour
{
    public static Timer instance;
    public Text TimerText;

    private TimeSpan timePlaying;
    public bool timerGoing;

    public float elapsedTime;

    public Text winner;

    public void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        TimerText.text = "00:00.00";
        timerGoing = false;
    }

    public void BeginTimer()
    {
        timerGoing = true;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()
    {
        timerGoing = false;
    }
    public void Win()
    {
        winner.text = TimerText.text;
    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = timePlaying.ToString("mm':'ss'.'ff");
            TimerText.text = timePlayingStr;

            yield return null;
        }
    }

}