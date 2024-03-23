using UnityEngine;
using UnityEngine.UI;

public class PanelButtonIcon : MonoBehaviour
{
    [SerializeField] private Image iconImage;

    public void DefineIcon(PanelButtonSO data)
    {
        iconImage.sprite = data.IconSprite;
    }
}
