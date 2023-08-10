using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemData : ScriptableObject
{
    [SerializeField]
    [Header("Database")]
    public ItemDataIndex[] ItemDB;
    public ItemType itemType;

    public static ItemData instance;

    private void Awake()
    {
        instance = this;
    }
}

[System.Serializable]
public struct ItemDataIndex
{
    public ItemType itemType;
    public GameObject itemSlot;
    public Sprite Icon;
    public Transform Item;
    public string Name;
    public int maxStack;
    public int price;
}
