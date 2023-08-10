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

    // �׹ۿ� �ʿ��� �κ�
    // HUD (������)�� ȣ�� ��ư�� ���� �ϴܿ� ������ SetActive �ǵ��� �����ϰ�
    // ���� HUD���� Inventory �������� �巡���ؼ� ���Կ� ������ ��ϵ� �� �ֵ��� �̺�Ʈ ����.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
