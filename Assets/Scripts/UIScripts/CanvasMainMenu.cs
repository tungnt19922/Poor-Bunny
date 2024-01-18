using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasMainMenu : MonoBehaviour
{
    [SerializeField] Text goldText;
    int gold;
    private void Start()
    {
        goldText.text = "" + gold;
    }

    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("Gameplay");
        AudioManager.Instance.PlayMusic("Play");
    }


}
