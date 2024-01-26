using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] private List<ShopSkinItem> shopSkinItem;
    [SerializeField] private List<ShopSkinItem> skinOwned;
    [SerializeField] private GameObject NotEnoughGoldPanel;

    public void SubtractGold(int gold)
    {
        if (gold <= GoldManager.Instance.CurrentGold())
        {
            GoldManager.Instance.SubtractGold(gold);
        }
        else
            NotEnoughGoldPanel.SetActive(true);
    }

}
