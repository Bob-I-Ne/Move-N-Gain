using UnityEngine;

[CreateAssetMenu(fileName = "New PanelButtonSO", menuName = "PanelButtons/BonusPanelButtonSO", order = 51)]
public class BonusPanelButtonSO : PanelButtonSO
{
    public PriceData Price;
    public MyBonuses.Bonus Bonus;
}
