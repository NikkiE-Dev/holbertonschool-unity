using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

///<summary>Creating Options Menu.</summary>
public class OptionsMenu : MonoBehaviour
{
    public Toggle invertY;
    public Button backButton;
    public Button applyButton;
    public Slider BGM;
    public static float bgmSlider;

    public Slider SFX;
    public static float sfxSlider;
    public AudioMixer masterMixer;


    void Start()
    {
        invertY.isOn = PlayerPrefs.GetInt("invertY") == 1;
        backButton.onClick.AddListener(Back);
        applyButton.onClick.AddListener(Apply);
        BGM.value = PlayerPrefs.GetFloat("BGMvol", 1);
        SFX.value = PlayerPrefs.GetFloat("SFXvol", 1);
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

    public void SetBGM(float sliderValue)
    {
        bgmSlider = sliderValue;
        masterMixer.SetFloat("BGMvol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("BGMvol", sliderValue);
    }
    // {
    //     masterMixer.SetFloat("BGMvol", Mathf.Log10(BGMvol) * 20);
    //     PlayerPrefs.SetFloat("BGMvol", BGMvol);
    // }
    public void SetSFX(float sliderValue)
    {
        sfxSlider = sliderValue;
        masterMixer.SetFloat("SFXvol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("SFXvol", sliderValue);
    }
    // {
    //     masterMixer.SetFloat("SFXvol", Mathf.Log10(SFXvol) * 20);
    //     PlayerPrefs.SetFloat("SFXvol", SFXvol);
    // }
}