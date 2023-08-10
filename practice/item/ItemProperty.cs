using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IInvenItem
{
    public string name { get; }
    public int id { get; }
    public Sprite img { get; }
}

public class ItemProperty : MonoBehaviour
{
    public IInvenItem item;
    public void invenItem(IInvenItem _item)
    {
        item = _item;
    }
    public ItemProperty[] slots;

    /****************************/
    #region SlotCount Property
    /*protected int _slotCount = 0;
    public virtual int SlotCount
    {
        get => _slotCount;
        set
        {
            _slotCount = value;
        }
    }*/
    #endregion

    #region Image Property
    Image _img = null;
    protected Image ItemImage
    {
        get
        {
            if (_img == null)
            {
                _img = GetComponent<Image>();
                if (_img == null)
                {
                    _img = GetComponentInChildren<Image>();
                }
            }
            return _img;
        }
    }
    #endregion

    #region Sprite Property
    Sprite _sprite = null;
    protected Sprite ItemSprite
    {
        get
        {
            if (_sprite == null)
            {
                _sprite = GetComponent<Sprite>();
                if (_img == null)
                {
                    _sprite = GetComponentInChildren<Sprite>();
                }
            }
            return _sprite;
        }
    }
    #endregion
}
