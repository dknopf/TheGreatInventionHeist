using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TigerForge;

public class SettingsSliderScript : MonoBehaviour
{
    public Slider slider;
    [Tooltip("set true for music slider, false for sfx slider")]
    public bool isMusicSlider = true;

    private void Start()
    {
        if (isMusicSlider)
        {
            slider.value = GlobalStaticVariables.musicVolume;
        }
        else
        {
            slider.value = GlobalStaticVariables.sfxVolume;
        }
    }

    public void SetSFXVolume ()
    {
        GlobalStaticVariables.sfxVolume = slider.value;
        //EventManager.EmitEvent(GameConstants.SfxVolumeChangeEvents);
    }
    public void SetMusicVolume ()
    {
        GlobalStaticVariables.musicVolume = slider.value;
        //EventManager.EmitEvent(GameConstants.MusicVolumeChangeEvent);
    }

}
