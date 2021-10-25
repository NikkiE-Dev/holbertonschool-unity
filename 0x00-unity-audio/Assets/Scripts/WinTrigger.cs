using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>Creating Timer to start once reaches the flag</summary>
public class WinTrigger : MonoBehaviour
{
    public GameObject player;
    public Text TimerText;
    public Text WinText;
    public GameObject TimerCanvas;
    public GameObject WinCanvas;
    public AudioSource WinSound;
    public AudioSource LvlMusic;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Timer.instance.EndTimer();
            player.GetComponent<Timer>().Win();
            Debug.Log ("Returned from Winscript");
            Cursor.visible = true;
            TimerCanvas.SetActive(false);
            WinCanvas.SetActive(true);
            Debug.Log ("WinCanvas should be true");
            LvlMusic.Stop();
            WinSound.Play();
        }
    }
}