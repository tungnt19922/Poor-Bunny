using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVFXButton : MonoBehaviour
{
    [SerializeField] private Sprite vfxOnImage;
    [SerializeField] private Sprite vfxOffImage;
    [SerializeField] private Button button;
    private bool isOn = true;
    private void Start()
    {
        vfxOnImage = button.image.sprite;
    }

    public void ButtonClicked()
    {
        if (isOn)
        {
            Debug.Log("sound off");
            button.image.sprite = vfxOffImage;
            isOn = false;
            AudioManager.Instance.ToggleSFX();
        }
        else
        {
            Debug.Log("sound on");
            button.image.sprite = vfxOnImage;
            isOn = true;
            AudioManager.Instance.ToggleSFX();
        }
    }
}
