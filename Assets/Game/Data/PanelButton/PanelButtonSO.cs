using System;
using UnityEngine;

[CreateAssetMenu(fileName = "New PanelButtonSO", menuName = "PanelButtons/PanelButtonSO", order = 51)]
public class PanelButtonSO : ScriptableObject
{
    public Sprite IconSprite;
    [TextArea(3, 10)] public string DescriptionText;


    [Serializable]
    public class PriceData
    {
        public string chargedResourceName;
        public int value;
    }
}
