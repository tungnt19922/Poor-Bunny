using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinSelect : MonoBehaviour
{
    public SkinType selectedSkin;

    private void Awake()
    {
        selectedSkin = GameState.Instance.CurrentSkin;
    }

    public void SelectedSkin(int skin)
    {
        GameState.Instance.CurrentSkin = (SkinType)skin;
    }
}
