using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; 
    [SerializeField] Text scoreText;
    [SerializeField] Text highScoreText;

    private int score = 0;
    private int highScore = 0;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        scoreText.text = "Score: " + score;
        highScoreText.text = "Highscore: " + highScore;
    }
    public void AddPointApple()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }    
    public void AddPointCherry()
    {
        score += 3;
        scoreText.text = "Score: " + score;
    }
}
