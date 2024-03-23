using UnityEngine;

[RequireComponent(typeof(PanelButtonDescription), typeof(PanelButtonIcon), typeof(PanelButtonPrice))]
public class BonusPanelButton : MonoBehaviour
{
    [SerializeField] private BonusPanelButtonSO data;

    [SerializeField] private PanelButtonIcon icon;
    [SerializeField] private PanelButtonDescription description;
    [SerializeField] private PanelButtonPrice price;

    private void Refresh()
    {
        icon.DefineIcon(data);
        description.DefineDescription(data);
        price.DefinePrice(data.Price);
    }

    public void Buy()
    {
        //buy things
    }

    private void OnEnable()
    {
        Refresh();
        WorldTicker.uiTick += Refresh;
    }

    private void OnDisable()
    {
        WorldTicker.uiTick -= Refresh;
    }
}
