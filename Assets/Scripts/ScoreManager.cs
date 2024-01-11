using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; 
    [SerializeField] Text scoreText;
    [SerializeField] Text highScoreText;

    private int _score = 0;
    private int highScore = 0;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        scoreText.text = "Score: " + _score;
        highScoreText.text = "Highscore: " + highScore;
    }
    public void AddPointApple()
    {
        _score += 1;
        scoreText.text = "Score: " + _score;
    }    
    public void AddPoint(int score)
    {
        _score += score;
        scoreText.text = "Score: " + _score;
    }
}
