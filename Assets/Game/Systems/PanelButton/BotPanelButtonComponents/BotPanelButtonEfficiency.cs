using UnityEngine;
using TMPro;

public class BotPanelButtonEfficiency : MonoBehaviour
{
    [SerializeField] private TMP_Text efficiencyText;

    public void DefineEfficiency(BotPanelButtonSO data)
    {
        efficiencyText.text = "x" + data.Efficiency.ToString();
    }
}
