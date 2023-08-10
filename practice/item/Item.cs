using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemType
{
    Equip,                  // 도구
    Material,               // 재료
    Consumable,             // 소모품
    Etc                     // 외
}

[System.Serializable]
public class Item
{
    public ItemType itemType;
    public string itemName;
    public GameObject itemGO;
    public Sprite itemImage;

    public bool Use()
    {
        return false;
    }
}
