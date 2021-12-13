using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;

    public void Start()
    {
        slider.value = PlayerPrefs.GetFloat("MusicVol", 0.75f);
    }


    public void SetLevelBGM(float sliderValue)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MusicVol", sliderValue);
    }
}
