using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CanvasGameplay : MonoBehaviour
{
    public void OnReplayButtonClicked()
    {
        Debug.Log("Player hoi sinh");
    }
    public void OnNonReplayButtonClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
