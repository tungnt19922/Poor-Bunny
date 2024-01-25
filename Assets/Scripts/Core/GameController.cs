using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private PlayerController playerController;

    private void Start()
    {
        playerController = SkinManager.Instance.GetPlayer();
        gameOverUI.SetActive(false);
        playerController.onDead += OnGameOver;
    }

    private void OnGameOver()
    {
        gameOverUI.SetActive(true);
    }
}
