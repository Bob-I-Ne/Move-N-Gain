using TMPro;
using UnityEngine;

public class BotPanelButtonCountOfBots : MonoBehaviour
{
    [SerializeField] private TMP_Text countOfBotsText;

    public void DefineCount(BotPanelButtonSO data)
    {
        countOfBotsText.text = "count: " + Storage.inst.GetBotCount("WeakRobot");
    }
}
