using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasShopMenu : MonoBehaviour
{
    [SerializeField] GameObject[] skinPanel;
    private int selectedPanel;
    [SerializeField] GameObject mainmenuPanel;
    [SerializeField] GameObject shopPanel;

    private void Start()
    {
        skinPanel[selectedPanel].SetActive(true);
    }

    public void NextPanel()
    {
        skinPanel[selectedPanel].SetActive(false);
        selectedPanel++;
        if (selectedPanel == skinPanel.Length)
            selectedPanel = 0;
        skinPanel[selectedPanel].SetActive(true);
    }

    public void PreviousPanel()
    {
        skinPanel[selectedPanel].SetActive(false);
        selectedPanel--;
        if (selectedPanel == -1)
            selectedPanel = skinPanel.Length - 1;
        skinPanel[selectedPanel].SetActive(true);
    }
}
