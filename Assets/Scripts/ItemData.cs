using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public ItemType itemType;
    public int rarity;
}

public enum ItemType
{
    Weapon,
    Tool,
    Magic,
    Other
}
