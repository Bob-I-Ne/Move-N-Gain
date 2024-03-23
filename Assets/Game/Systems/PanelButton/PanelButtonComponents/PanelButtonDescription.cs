using UnityEngine;
using TMPro;

public class PanelButtonDescription : MonoBehaviour
{
    [SerializeField] private TMP_Text descriptionText;

    public void DefineDescription(PanelButtonSO data)
    {
        descriptionText.text = data.DescriptionText;
    }
}
