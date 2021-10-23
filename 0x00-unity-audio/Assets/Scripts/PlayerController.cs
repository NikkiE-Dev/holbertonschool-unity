using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>Creating Player.</summary>
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 7f;
    [SerializeField]
    private float _gravity = 8f;
    [SerializeField]
    private float _jumpSpeed = 4.5f;
    [SerializeField]
    private float _jumpMultiplier = 1.15f;

    public Transform respawnPoint;

    private CharacterController controller;

    public GameObject plyr;

    private float _movingY;

    // Initializing game
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementHor = Input.GetAxisRaw("Horizontal");
        float movementVer = Input.GetAxisRaw("Vertical");


        Vector3 moving = transform.right * movementHor + transform.forward * movementVer;

        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            _movingY = _jumpSpeed * _jumpMultiplier;
        }

        _movingY -= _gravity * Time.deltaTime;

        moving.y = _movingY;

        controller.Move(moving * _moveSpeed * Time.deltaTime);
    }


    void FixedUpdate()
    {
        if (plyr.transform.position.y < -30)
        {
            plyr.transform.position = respawnPoint.transform.position;
        }

    }
}
