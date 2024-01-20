using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldManager : MonoBehaviourSingletonPersistent<GoldManager>
{
    [SerializeField] Text goldText;

    private int _gold = 0;
    private int _asset = 0;

    private void Start()
    {
        goldText.text = ": " + _gold;
        LoadGold();
    }
    public void AddGold(int gold)
    {
        _gold += gold;
        goldText.text = ": " + _gold;
        SaveGold();
    }
    public void SaveGold()
    {
        PlayerPrefs.SetInt("PlayerGold", _asset);
        PlayerPrefs.Save();
    }
    public void LoadGold()
    {
        _gold = PlayerPrefs.GetInt("PlayerGold", _asset);
    }
}
