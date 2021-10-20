using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>Creating Win Menu</summary>
public class WinMenu : MonoBehaviour
{
    public void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Next()
    {
        if (SceneManager.GetActiveScene().buildIndex < 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }

    }
}