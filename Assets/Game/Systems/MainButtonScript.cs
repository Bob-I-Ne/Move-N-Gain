using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonScript : MonoBehaviour
{
    public BigButtonSO button_data;
    private string curr_resource;
    private AudioClip click_sound;

    void Start()
    {
        Init(button_data);
    }
    public void Init(BigButtonSO data)
    {
        GetComponent<Image>().sprite = button_data.sprite;
        curr_resource = button_data.resource;
        click_sound = button_data.sound_on_click;
        Storage.inst.SetCurrentResource(curr_resource);
    }
    public void Clicked()
    {
        AudioManager.inst.Play(click_sound);
        Storage.inst.ChangeResourceCount(Storage.inst.GetCurrentResource(), MyBonuses.inst.bonuses["MainButtonClick"]);
    }
}
