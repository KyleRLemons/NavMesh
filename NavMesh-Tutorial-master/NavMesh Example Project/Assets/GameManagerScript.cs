using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoresText;
    public TextMeshProUGUI livesText;
    public GameObject GameOverCanvas;
    public GameObject WinCanvas;

    public static int lives = 1;
    public static int points = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoresText.text = "Score: " + points;
        livesText.text = "Lives: " + lives;

        if(lives <= 0)
        {
            Time.timeScale = 0;
            GameOverCanvas.SetActive(true);

        }
        if(points >= 5)
        {
            Time.timeScale = 0;
            WinCanvas.SetActive(true);
        }
    }

    public void Restart()
    {
        Time.timeScale = 1;
        lives = 5;
        points = 0;
        SceneManager.LoadScene("Example01 - Basics");
        
    }
}
