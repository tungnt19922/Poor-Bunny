using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasMainMenu : MonoBehaviour
{
    [SerializeField] GameObject mainmenuPanel;
    [SerializeField] GameObject shopPanel;

    private void Start()
    {
        mainmenuPanel.SetActive(true);
        shopPanel.SetActive(false);
    }

    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("Gameplay");
        AudioManager.Instance.PlayMusic("Play");
    }

    public void OnShopButtionClicked()
    {
        mainmenuPanel.SetActive(false);
        shopPanel.SetActive(true);
    }
}
