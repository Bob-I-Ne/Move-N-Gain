using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class StorageUpdater : MonoBehaviour
{
    public TMP_Text[] resources = new TMP_Text[7];

    void Start()
    {
        WorldTicker.uiTick += UpdateStorRes;
    }

    private void UpdateStorRes()
    {
        foreach (var resource in resources) 
        {
            resource.text = Storage.inst.GetResourceCount(resource.name).ToString();
        }
    }
}
