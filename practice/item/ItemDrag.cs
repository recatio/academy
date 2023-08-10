using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDrag : ItemProperty, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{

    public Transform orgItemSlotTf;
    public GameObject itemIcon;

    public void OnBeginDrag(PointerEventData eventData) 
    {
        ItemImage.raycastTarget = false;

        orgItemSlotTf = transform.parent;
        transform.SetParent(transform.parent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        itemIcon.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        itemIcon.transform.position = orgItemSlotTf.position;
    }

    public void OnDrop(PointerEventData eventData)
    {
        itemIcon.SetActive(false);
        itemIcon.transform.localPosition = eventData.position;
    }
}
