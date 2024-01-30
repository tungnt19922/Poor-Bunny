using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuySkin : MonoBehaviour
{
    [SerializeField] private List<ShopItemHandler> shopItemHandlers;
    private void Start()
    {
    }
    public void OnBuyButtonClicked(int gold)
    {
        if (gold <= GoldManager.Instance.Asset())
        {
            GoldManager.Instance.SubtractGold(gold);
            Debug.Log("mua xong skin");
            //buyButton.gameObject.SetActive(false);
            //ChooseSkinButton.interactable = true;
        }
    }
}
