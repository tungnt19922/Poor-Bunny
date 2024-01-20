using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasShopMenu : MonoBehaviour
{
    [SerializeField] GameObject mainmenuPanel;
    [SerializeField] GameObject shopPanel;

    public void BackButtonClicked()
    {
        mainmenuPanel.SetActive(true);
        shopPanel.SetActive(false);
    }
}
