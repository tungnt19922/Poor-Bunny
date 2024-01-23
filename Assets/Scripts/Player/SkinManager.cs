using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviourSingleton<SkinManager>
{
    [SerializeField] private List<PlayerSkin> players;
    public PlayerController GetPlayer()
    {
        return null;
    }
    
}
