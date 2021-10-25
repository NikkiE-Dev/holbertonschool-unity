using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

///<summary>Creating Volume control.</summary>
public class VolumeControl : MonoBehaviour
{
    public AudioMixer masterMixer;

    public void SetBGMlvl(float BGMvol)
    {
        masterMixer.SetFloat("BGMvol", Mathf.Log10(BGMvol) * 20);
    }
    public void SetSFXlvl(float SFXvol)
    {
        masterMixer.SetFloat("SFXvol", Mathf.Log10(SFXvol) * 20);
    }

    // [SerializeField] string volumeLevel = "VolumeLevel";
    // [SerializeField] Slider BGMslider;
    // [SerializeField] AudioMixer BGMmixer;
    // [SerializeField] private float _multiplier = 30f;


    // private void Awake()
    // {
    //     BGMslider.onValueChanged.AddListener(ValueChanged);
    // }
    // void ValueChanged(float value)
    // {
    //     BGMmixer.SetFloat(volumeLevel, Mathf.Log10(value) * _multiplier);
    // }
}