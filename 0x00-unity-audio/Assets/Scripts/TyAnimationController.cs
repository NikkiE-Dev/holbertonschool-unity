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
    }

    void Update()
    {
        float movementHor = Input.GetAxisRaw("Horizontal");
        float movementVer = Input.GetAxisRaw("Vertical");

        if (movementHor !=0 || movementVer != 0)
        {
            anime.SetBool("isRunning", true);
            RunSound.Play();
        }
        else
        {
            anime.SetBool("isRunning", false);
            RunSound.Stop();
        }

        if (Input.GetButtonDown("Jump"))
        {
            anime.SetBool("isJumping", true);
        }
        else
        {
            anime.SetBool("isJumping", false);
        }
        if (anime.GetCurrentAnimatorStateInfo(0).IsName("Falling Flat Impact"))
        {
            LandingSound.Play();
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