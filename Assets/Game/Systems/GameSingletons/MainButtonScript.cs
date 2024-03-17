using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MainButtonScript : MonoBehaviour
{

    public BigButtonSO button_data;
    public Storage Storage;
    public MyBonuses MyBonuses;
    public AudioSource click_S;
    private SpriteRenderer spriteR;
    private Sprite button_sprite;
    private string curr_resource;
    private AudioClip click_sound;

    void Start()
    {
        button_sprite = button_data.sprite;
        curr_resource = button_data.resource;
        click_sound = button_data.sound_on_click;

        spriteR = GetComponent<SpriteRenderer>();
        spriteR.sprite = button_sprite;
        Storage.SetCurrentResource(curr_resource);
    }

    public void Clicked()
    {
        print("aboba");
        click_S.PlayOneShot(click_sound);
        Storage.ChangeResourceCount(Storage.GetCurrentResource(), MyBonuses.bonuses["MainButtonClick"]);
    }
}
