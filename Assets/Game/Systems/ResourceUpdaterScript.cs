using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResourceUpdaterScript : MonoBehaviour
{
    public TMP_Text Res_P;
    public TMP_Text BigNum;

    public void Start()
    {
        WorldTicker.uiTick += UpdateResProd;
        WorldTicker.uiTick += UdpateBigNum;
    }

    private void UpdateResProd()
    {
        Res_P.text = "Ресурсов в секунду: " + Storage.inst.GetResourceCount(Storage.inst.GetCurrentResource()).ToString();
    }
    private void UdpateBigNum()
    {
        BigNum.text = Storage.inst.GetResourceCount(Storage.inst.GetCurrentResource()).ToString();
    }
}
