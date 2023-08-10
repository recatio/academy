using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Money : MonoBehaviour
{
    GuideUI guideUI;
    public TMP_Text AmountText;       //������ ǥ��
    public Image MoneyUI;             //�������� ǥ��� ��ġ��

    [HideInInspector]
    int Amount = 0, MaxAmount = 999999, Price;   // ������ ����

    // ���� �����ݾ��� 1,000�� �Ѿ�� ��� ���ڸ��� K�� �ٵ��� �ؾ���
    // (ǥ��� ������ �����ϱ�)

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    #region ������ ���� �� ������
    void BuyResult()
    {
        if (AmountText != null)
        {
            if (Amount > Price) // �������� ���Ű����� Ŭ ���� ����
            {
                Amount -= Price;
            }
            else
            {
                guideUI.GuideMessage("��! �ݾ��� �����ؼ� ������ �� ����..");
            }
        }
    }
    #endregion

    #region ������ �Ǹ� �� ������
    void SellResult()
    {
        if (AmountText != null)
        {
            if (Amount < MaxAmount) // �������� ������ ����ġ���� ���� ���� �Ǹ�
            {
                Amount += Price;
            }
            else
            {
                guideUI.GuideMessage("��! ������ �������� ���̻� ���� ���� �� ����\n �׷��� �Ǹ��ұ�?");
            }
        }
    }
    #endregion

}
