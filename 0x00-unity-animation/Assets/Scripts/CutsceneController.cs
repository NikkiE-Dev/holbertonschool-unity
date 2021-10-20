using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

///<summary>Creating Cutscene Camera control and angles.</summary>
public class CutsceneController : MonoBehaviour
{
    public GameObject MainCam;
    public GameObject CutsceneCam;
    public GameObject Player;
    public GameObject TimerCanvas;
    public Animator Ani;


    void Start()
    {
        CutsceneCam = GameObject.Find("CutsceneCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (Ani.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            CutsceneCam.SetActive(false);
            TimerCanvas.SetActive(true);
            MainCam.SetActive(true);
            Player.GetComponent<PlayerController>().enabled = true;
        }
    }
}