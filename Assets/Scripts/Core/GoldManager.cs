using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldManager : MonoBehaviourSingleton<GoldManager>
{
    [SerializeField] int gold;
    public void SaveGold()
    {
        PlayerPrefs.SetInt("PlayerCoin", gold);
        PlayerPrefs.Save();
    }
    public void LoadGold()
    {
        gold = PlayerPrefs.GetInt("PlayerCoin", 0);
    }
    public void AddGold(int score)
    {
        gold += score;
    }
}
