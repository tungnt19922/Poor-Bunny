using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private PlayerController playerController;

    public GameObject[] playerPrefabs;
    int characterIndex;
    public static Vector2 startPosition = new Vector2(0, 0);

    private void Awake()
    {
        characterIndex = PlayerPrefs.GetInt("SelectedSkin", 0);
        Instantiate(playerPrefabs[characterIndex], startPosition, Quaternion.identity);
    }

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        gameOverUI.SetActive(false);
        playerController.onDead += OnGameOver;
    }

    private void OnGameOver()
    {
        gameOverUI.SetActive(true);
    }
}
