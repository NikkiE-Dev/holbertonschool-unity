using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>Creating Options Menu.</summary>
public class OptionsMenu : MonoBehaviour
{
    public Toggle invertY;
    public Button backButton;
    public Button applyButton;

    void Start()
    {
        invertY.isOn = PlayerPrefs.GetInt("invertY") == 1;
        backButton.onClick.AddListener(Back);
        applyButton.onClick.AddListener(Apply);
    }
    public void Back()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("lastScene"));
    }
    public void Apply()
    {
        if (invertY.isOn == false)
        {
            PlayerPrefs.SetInt("invertY", 0);
        }

        if (invertY.isOn == true)
        {
            PlayerPrefs.SetInt("invertY", 1);
        }
       PlayerPrefs.Save();
       SceneManager.LoadScene(PlayerPrefs.GetInt("lastScene"));
    }
}