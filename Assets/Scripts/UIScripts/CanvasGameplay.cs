using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CanvasGameplay : MonoBehaviour
{
    [SerializeField] GameObject gameOverUI;

    public void OnReplayButtonClicked()
    {
        SceneManager.LoadScene("Gameplay");
        gameOverUI.SetActive(false);
    }
    public void OnNonReplayButtonClicked()
    {
        SceneManager.LoadScene("MainMenu");
        AudioManager.Instance.PlayMusic("Theme");
        gameOverUI.SetActive(false);
    }
}
