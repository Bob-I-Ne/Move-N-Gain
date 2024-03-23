using UnityEngine;

[RequireComponent(typeof(PanelButtonDescription), typeof(PanelButtonIcon))]
[RequireComponent(typeof(BotPanelButtonCountOfBots), typeof(BotPanelButtonEfficiency), typeof(PanelButtonPrice))]
public class BotPanelButton : MonoBehaviour
{
    [SerializeField] private BotPanelButtonSO data;

    [SerializeField] private PanelButtonIcon icon;
    [SerializeField] private PanelButtonDescription description;
    [SerializeField] private PanelButtonPrice price;

    [SerializeField] private BotPanelButtonCountOfBots countOfBots;
    [SerializeField] private BotPanelButtonEfficiency efficiency;

    private void Refresh()
    {
        icon.DefineIcon(data);
        description.DefineDescription(data);
        countOfBots.DefineCount(data);
        efficiency.DefineEfficiency(data);
        price.DefinePrice(data.Price);
    }

    public void Buy()
    {
        Storage.inst.ChangeBotCount(data.BotName, 1);
    }

    private void OnEnable()
    {
        //Refresh();
        WorldTicker.uiTick += Refresh;
    }

    private void OnDisable()
    {
        WorldTicker.uiTick -= Refresh;
    }
}
