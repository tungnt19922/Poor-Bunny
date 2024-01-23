using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinSelect : MonoBehaviour
{
    public int selectedSkin; 
    private void Awake()
    {
        selectedSkin = PlayerPrefs.GetInt("SelectedSkin", 0);
    }


    public void SelectedSkin1 ()
    {
        PlayerPrefs.SetInt("SelectedSkin", 1);
    }
    public void SelectedSkin0 ()
    {
        PlayerPrefs.SetInt("SelectedSkin", 0);
    }

}
