using UnityEngine;

public class GameState : MonoBehaviourSingleton<GameState>
{
    private SkinType _currentSkin;

    public SkinType CurrentSkin { get => _currentSkin; set => _currentSkin = value; }

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        LoadSkin();
    }

    private void LoadSkin()
    {
        CurrentSkin = (SkinType)PlayerPrefs.GetInt("SelectedSkin", 0);
    }

    private void OnApplicationPause(bool pause)
    {
        if (pause)
            PlayerPrefs.Save();
    }

}
