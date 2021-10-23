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
        }
        else
        {
            anime.SetBool("isRunning", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            anime.SetBool("isJumping", true);
        }
        else
        {
            anime.SetBool("isJumping", false);
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