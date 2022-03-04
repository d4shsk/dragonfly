using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject pauseCanvas;
    [SerializeField] ScoreCounter scoreCounter;

    void Start()
    {
        pauseCanvas.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            pauseCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void StartPause() {
        if (PlayerPrefs.HasKey("Score"))
        {
            float oldScore = PlayerPrefs.GetFloat("Score");

            if (scoreCounter.score > oldScore)
            {
                PlayerPrefs.SetFloat("Score", scoreCounter.score);
            }
        }
        else
        {
            PlayerPrefs.SetFloat("Score", scoreCounter.score);
        }
        pauseCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void StopPause()
    {
        Time.timeScale = 1;
        if (!EndGame.restart)
        {
            pauseCanvas.SetActive(false);
        }
        else {
            SceneManager.LoadScene(1);
        }
        
    }

    public void GoToStartMenu() {

        if (PlayerPrefs.HasKey("Score"))
        {
            float oldScore = PlayerPrefs.GetFloat("Score");

            if (scoreCounter.score > oldScore)
            {
                PlayerPrefs.SetFloat("Score", scoreCounter.score);
            }
        }
        else
        {
            PlayerPrefs.SetFloat("Score", scoreCounter.score);
        }

        SceneManager.LoadScene(0);
    }
}
