using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemType
{
    Equip,                  // ����
    Material,               // ���
    Consumable,             // �Ҹ�ǰ
    Etc                     // ��
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
