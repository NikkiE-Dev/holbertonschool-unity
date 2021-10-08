using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;

    public bool isRotated;
    public Vector3 offset;

    float X = 0f;
    float Y = 0f;

    void Start()
    {
        //offset = transform.position - Player.transform.position;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        if (PlayerPrefs.GetInt("isRotated") == 1)
        {
            isRotated = true;
        }
        else
        {
            isRotated = false;
        }
    }

    void Update()
    {
        //transform.position = Player.transform.position + offset;
        X += Input.GetAxisRaw("Mouse X");
        if (isRotated)
        {
            Y = Mathf.Clamp(Y + Input.GetAxisRaw("Mouse Y"), -30, 60);
        }
        else
        {
            Y = Mathf.Clamp(Y - Input.GetAxisRaw("Mouse Y"), -30f, 60f);
        }
    }

    void LateUpdate()
    {
        Quaternion rotation = Quaternion.Euler(Y, X, 0);
        transform.position = Player.position + rotation * new Vector3(0, 0, -6.25f);
        transform.LookAt(Player);
    }
}
