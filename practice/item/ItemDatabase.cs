using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    [HideInInspector]
    public ItemData itemdata;
    public static ItemDatabase instance;

    private void Awake()
    {
        instance = this;
    }

    public List<Item> itemDB = new();

    [Space(20)]
    public GameObject DropItemPrefab;
    public Vector3[] pos;

    private void Start()
    {
        FieldCreateItem(gameObject);
    }

    #region 필드에 아이템을 생성하는 함수
    void FieldCreateItem(GameObject go)
    {
        // 반복문을 통해 몇개까지 생성할 것인지 value 지정
        // 또한 Inspector parameter값이 아래 입력값들과 일치해야 오류가 나지 않음
        for (int i = 0; i < 6; i++)
        {
            go = Instantiate(DropItemPrefab, pos[i], Quaternion.identity);
            go.GetComponent<FieldItems>().SetItem(itemDB[Random.Range(0, 3)]);
        }
        return;
    }
    #endregion
}
