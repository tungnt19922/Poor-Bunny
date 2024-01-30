using System;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviourSingleton<SkinManager>
{
    [SerializeField] private List<PlayerSkin> players;
    private PlayerController currentPlayer;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        DeactiveSkins();
        EnableCurrentSkin();
    }

    private void EnableCurrentSkin()
    {
        var currentSkin = GameState.Instance.CurrentSkin;
        var currentSkinPlayer = players.Find(playerSkin => playerSkin.type == currentSkin);
        if (currentSkinPlayer != null)  
        {
            currentPlayer = currentSkinPlayer.player;
            currentPlayer.gameObject.SetActive(true);
        }
    }

    private void DeactiveSkins()
    {
        foreach (var playerSkin in players)

        {
            playerSkin.player.gameObject.SetActive(false);
        }
    }

    public PlayerController GetPlayer()
    {
        return currentPlayer;
    }
}
