using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

///<summary>Creating Player.</summary>
public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public CharacterController controller;
    public Rigidbody move;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;


    ///<summary>Initializing game</summary>
    void Start()
    {
        controller = GetComponent<CharacterController> ();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
         {
             isGrounded = true;
         }

    void Update()
    {
        if (Input.GetKey("a"))
        {
            move.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            move.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            move.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            move.AddForce(0, 0, -speed * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            move.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
