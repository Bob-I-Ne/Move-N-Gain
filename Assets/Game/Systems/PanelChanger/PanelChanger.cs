using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{
    [SerializeField] private GameObject[] panels = new GameObject[6];

    public void ChangePanel(int num)
    {
        for(int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(i == num);
        }
    }
}
