using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResourceUpdater : MonoBehaviour
{
    public TMP_Text resPerSec;
    public TMP_Text bigNum;

    public void Start()
    {
        WorldTicker.uiTick += UpdateResProd;
        WorldTicker.uiTick += UdpateBigNum;
    }

    private void UpdateResProd()
    {
        resPerSec.text = "Ресурсa в секунду: " + "0"; //потом нужно брать информацию об производительности
    }
    private void UdpateBigNum()
    {
        bigNum.text = Storage.inst.GetResourceCount(Storage.inst.GetCurrentResource()).ToString();
    }
}
