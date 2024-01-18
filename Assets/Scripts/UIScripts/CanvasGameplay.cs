using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CanvasGameplay : MonoBehaviour
{
    public void OnReplayButtonClicked()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void OnNonReplayButtonClicked()
    {
        SceneManager.LoadScene("MainMenu");
        AudioManager.instance.PlayMusic("Theme");
    }
}
