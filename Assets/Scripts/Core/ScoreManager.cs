using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviourSingleton<ScoreManager>
{
    [SerializeField] Text scoreText;
    [SerializeField] Text highScoreText;

    private int _score = 0;
    private int highScore = 0;

    private void Start()
    {
        scoreText.text = "Score: " + _score;
        highScoreText.text = "Highscore: " + highScore;

    }
    public void AddPoint(int score)
    {
        _score += score;
        scoreText.text = "Score: " + _score;
    }
    public void SaveCoin()
    {
        PlayerPrefs.SetInt("PlayerCoin", _score);
        PlayerPrefs.Save();
    }
    public void LoadCoin()
    {
        _score = PlayerPrefs.GetInt("PlayerCoin", 0);
    }
}
