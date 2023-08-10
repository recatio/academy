using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Money : MonoBehaviour
{
    GuideUI guideUI;
    public TMP_Text AmountText;       //소지금 표기
    public Image MoneyUI;             //소지금이 표기될 위치값

    [HideInInspector]
    int Amount = 0, MaxAmount = 999999, Price;   // 소지금 관련

    // 만약 소지금액이 1,000을 넘어가는 경우 뒷자리에 K가 붙도록 해야함
    // (표기될 공간이 작으니까)

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    #region 아이템 구매 후 소지금
    void BuyResult()
    {
        if (AmountText != null)
        {
            if (Amount > Price) // 소지금이 구매가보다 클 때만 차감
            {
                Amount -= Price;
            }
            else
            {
                guideUI.GuideMessage("앗! 금액이 부족해서 구입할 수 없어..");
            }
        }
    }
    #endregion

    #region 아이템 판매 후 소지금
    void SellResult()
    {
        if (AmountText != null)
        {
            if (Amount < MaxAmount) // 소지금이 소지금 상한치보다 작을 때만 판매
            {
                Amount += Price;
            }
            else
            {
                guideUI.GuideMessage("앗! 지갑이 가득차서 더이상 돈을 받을 수 없어\n 그래도 판매할까?");
            }
        }
    }
    #endregion

}
