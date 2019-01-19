using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour
{
    int score = 0;
    GameObject scoreText;
    GameObject gameOverText;
    public rockController rockController;


    public void GameOver()
    {
        this.gameOverText.GetComponent<Text>().text = "GameOver";
    }

    public void AddScore()
    {
        //int G_flag;
        //G_flag = rockController.GameOver_flag;
        //if (G_flag != 1)  
        this.score += 10;
    }

    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("GameOver");
    }

    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
    }
}
