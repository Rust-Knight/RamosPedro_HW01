using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; 
    
    public Text scoreText;
    //public Text highscoreText;

    int score = 0;
    int highscore = 0;


    private void Awake()
    {
        instance = this; 
    }

    private void Start()
    {
        scoreText.text = "Coins " + score.ToString(); //score.ToString() + "Coins";
        //highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = "Coins "  + score.ToString(); 
    }

}
