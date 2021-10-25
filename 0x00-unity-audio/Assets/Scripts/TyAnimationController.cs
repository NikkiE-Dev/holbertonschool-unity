using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>Creating Animation Player controls.</summary>
public class TyAnimationController : MonoBehaviour
{
    private Animator anime;
    public GameObject Plyr;
    public bool isFalling;
    public bool isRunning;
    public bool IsJumping;
    public AudioSource RunSound;
    public AudioSource LandingSound;

    void Start()
    {
        anime = GetComponent<Animator>();
        RunSound.mute = true;
        LandingSound.mute = true;
    }

    void Update()
    {
        float movementHor = Input.GetAxisRaw("Horizontal");
        float movementVer = Input.GetAxisRaw("Vertical");

        if (movementHor !=0 || movementVer != 0)
        {
            isRunning = true;
            anime.SetBool("isRunning", true);
            RunSound.mute = false;
        }
        else
        {
            isRunning = false;
            anime.SetBool("isRunning", false);
            RunSound.mute = true;
        }

        if (Input.GetButtonDown("Jump"))
        {
            anime.SetBool("isJumping", true);
        }
        else if (IsJumping == true && isRunning == true)
        {
            RunSound.mute = true;
        }
        else
        {
            anime.SetBool("isJumping", false);
        }

        if (anime.GetCurrentAnimatorStateInfo(0).IsName("Falling Flat Impact"))
        {
            LandingSound.mute = false;
        }
        else
        {
            LandingSound.mute = true;
        }
    }
    void FixedUpdate()
    {
        if (Plyr.transform.position.y < -2)
        {
            anime.SetBool("isFalling", true);
        }
        else
        {
            anime.SetBool("isFalling", false);
        }
    }

}