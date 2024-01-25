using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public ShopSkinItem[] shopSkinItem;
    public ShopSkinItem[] skinOwned;
    [SerializeField] private GameObject NotEnoughGoldPanel;

    private void Start()
    {

    }
    public void SubtractGold(int gold)
    {
        if (gold > GoldManager.Instance.CurrentGold())
            GoldManager.Instance.SubtractGold(gold);
        else
            NotEnoughGoldPanel.SetActive(true);
    }

    public void BuySkin(ShopSkinItem skin)
    {
        if (skin.UnlockSkin() == true)
        {

        }
        else
        {
            SubtractGold(skin.price);
        }
    }

}
