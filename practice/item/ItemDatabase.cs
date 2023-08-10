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

    #region �ʵ忡 �������� �����ϴ� �Լ�
    void FieldCreateItem(GameObject go)
    {
        // �ݺ����� ���� ����� ������ ������ value ����
        // ���� Inspector parameter���� �Ʒ� �Է°���� ��ġ�ؾ� ������ ���� ����
        for (int i = 0; i < 6; i++)
        {
            go = Instantiate(DropItemPrefab, pos[i], Quaternion.identity);
            go.GetComponent<FieldItems>().SetItem(itemDB[Random.Range(0, 3)]);
        }
        return;
    }
    #endregion
}
