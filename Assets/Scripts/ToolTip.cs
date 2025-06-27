using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Enums;

public class Tooltip : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;
    public GameObject tooltipPanel;

    private readonly Dictionary<Rarity, Color> rarityColors = new()
    {
        { Rarity.Common, Color.gray },
        { Rarity.Rare, Color.blue },
        { Rarity.Epic, new Color(0.6f, 0.2f, 0.8f) },
        { Rarity.Legendary, Color.yellow }
    };

    public void ShowTooltip(Items item)
    {
        if (item == null) return;

        titleText.text = $"{item.rarity} <color=#{ColorUtility.ToHtmlStringRGB(rarityColors[item.rarity])}>{item.itemName}</color>";
        descriptionText.text = item.description;
        tooltipPanel.SetActive(true);
    }

    public void HideTooltip()
    {
        tooltipPanel.SetActive(false);
    }
}

