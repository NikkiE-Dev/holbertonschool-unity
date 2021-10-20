using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>Creating Main Menu.</summary>
public class MainMenu : MonoBehaviour
{
    public void LevelSelect(int level)
    {
        SceneManager.LoadScene("Level" + level.ToString ("00"));
    }

    public void Options()
    {
        PlayerPrefs.SetInt("lastScene", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Options");
    }

    public void QuitGame()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
}