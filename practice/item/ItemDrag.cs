using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDrag : ItemProperty, IBeginDragHandler, IDragHandler, IEndDragHandler
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

    public void OnDrop()
    {
        itemIcon.SetActive(false);
        itemIcon.transform.localPosition = transform.position;
    }

    // 그밖에 필요한 부분
    // HUD (퀵슬롯)를 호출 버튼을 통해 하단에 별도로 SetActive 되도록 설정하고
    // 역시 HUD에도 Inventory 아이템을 드래그해서 슬롯에 넣으면 등록될 수 있도록 이벤트 설정.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
