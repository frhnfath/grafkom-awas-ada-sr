using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Score : MonoBehaviour
{
    public string name;
    public int score;
    public Text scoreText;
    public Text HIScoreText;

    float timer;
    float maxTime;

    // Start is called before the first frame update
    void Start()
    {
        HIScoreText.text = "HI    " + PlayerPrefs.GetInt("highscore", 0).ToString("000000");
        score = 0;
        scoreText = GetComponent<Text>();
        maxTime = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            score++;
            scoreText.text = score.ToString("000000");
            timer = 0;

        }

        if (Time.timeScale == 0)
        {
            if (score > PlayerPrefs.GetInt("highscore", 0))
            {
                PlayerPrefs.SetInt("highscore", score);
                HIScoreText.text = "HI    " + PlayerPrefs.GetInt("highscore", 0).ToString("000000");
            }
        }
    }

    public Score(string name, int score) {
        this.name = name;
        this.score = score;
    }
}
