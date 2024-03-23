using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PanelButtonSO", menuName = "PanelButtons/BotPanelButtonSO", order = 51)]
public class BotPanelButtonSO : PanelButtonSO
{
    public string BotName;
    public PriceData Price;
    public float Efficiency;
}
