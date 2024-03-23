using TMPro;
using UnityEngine;

public class PanelButtonPrice : MonoBehaviour
{
    [SerializeField] private TMP_Text priceText;

    public void DefinePrice(PanelButtonSO.PriceData price)
    {
        priceText.text = price.chargedResourceName + ": " + price.value.ToString();
    }
}
