using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeValue : MonoBehaviour
{
    public void SetMusicVolume(Slider slider)
    {
        AudioManager.inst.SetMusicVolume(slider.value);
    }
    public void SetSoundVolume(Slider slider)
    {
        AudioManager.inst.SetSoundVolume(slider.value);
    }
}