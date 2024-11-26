using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI livesDisplay;

    //ScreenLimits
    [Header("Screen Limits")]
    public float horizontalLimit;
    public float verticalLimit;
    public float offset;
    public float safetyRadius;

    public int lives;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //Initialize
        score = 0;
        lives = 3;
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        scoreDisplay.text = $"Score: {score}";
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScore();
    }

    public void LoseLife()
    {
        lives--;
        UpdateLives();
    }

    public void UpdateLives()
    {
        if(lives==3)
        {
            livesDisplay.text = "AAA";
        }

        if(lives == 2)
        {
            livesDisplay.text = "AA";
        }

        if(lives==1)
        {
            livesDisplay.text = "A";
        }

        if(lives==0)
        {
            livesDisplay.text = "";
            Destroy(player);
            SceneManager.LoadScene("GameOver");
        }
    }
}
