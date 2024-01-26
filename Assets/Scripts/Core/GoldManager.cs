using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldManager : MonoBehaviourSingletonPersistent<GoldManager>
{
    [SerializeField] Text goldText;

    [SerializeField] private int _gold = 0;

    private void Start()
    {
        LoadGold();
        goldText.text = ": " + _gold;
    }
    public void AddGold(int gold)
    {
        _gold += gold;
        goldText.text = ": " + _gold;
        SaveGold();
    }    
    public void SubtractGold(int gold)
    {
        _gold -= gold;
        goldText.text = ": " + _gold;
        SaveGold();
    }

    public void SaveGold()
    {
        PlayerPrefs.SetInt("PlayerGold", _gold);
        PlayerPrefs.Save();
    }
    public void LoadGold()
    {
        _gold = PlayerPrefs.GetInt("PlayerGold", 0);
    }
    public int CurrentGold()
    {
        return _gold;
    }

}
