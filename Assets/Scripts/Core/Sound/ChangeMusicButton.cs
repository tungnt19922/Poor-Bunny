using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMusicButton : MonoBehaviour
{
    [SerializeField] private Sprite soundOnImage;
    [SerializeField] private Sprite soundOffImage;
    [SerializeField] private Button button;
    private bool isOn = true;
    private void Start()
    {
        soundOnImage = button.image.sprite;
    }

    public void ButtonClicked()
    {
        if (isOn)
        {
            Debug.Log("sound off");
            button.image.sprite = soundOffImage;
            isOn = false;
            AudioManager.instance.ToggleMusic();
        }
        else
        {
            Debug.Log("sound on");
            button.image.sprite = soundOnImage;
            isOn = true;
            AudioManager.instance.ToggleMusic();
        }
    }
}
