using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviourSingleton<ScoreManager>
{
    [SerializeField] Text scoreText;

    private int _score = 0;

    private void Start()
    {
        scoreText.text = "Score: " + _score;
    }
    public void AddPoint(int score)
    {
        _score += score;
        scoreText.text = "Score: " + _score;
        GoldManager.Instance.AddGold(score);
    }
}
