using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonScript : MonoBehaviour
{
    public BigButtonSO startButtonData;
    private BigButtonSO myData;
    void Start()
    {
        Init(startButtonData);
    }
    public void Init(BigButtonSO data)
    {
        myData = data;
        GetComponent<Image>().sprite = myData.sprite;
        Storage.inst.SetCurrentResource(myData.resource);
    }
    public void Clicked()
    {
        AudioManager.inst.Play(myData.soundOnClick);
        Storage.inst.ChangeResourceCount(Storage.inst.GetCurrentResource(), MyBonuses.inst.bonuses["MainButtonClick"]);
    }
}
