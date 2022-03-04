using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public static bool restart;

    [SerializeField] ScoreCounter scoreCounter;
    [SerializeField] MenuController menuCounter;

    private void Start()
    {
        restart = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            if (PlayerPrefs.HasKey("Score"))
            {
                float oldScore = PlayerPrefs.GetFloat("Score");

                if (scoreCounter.score > oldScore) {
                    PlayerPrefs.SetFloat("Score", scoreCounter.score);
                }
            }
            else {
                PlayerPrefs.SetFloat("Score", scoreCounter.score);
            }

            restart = true;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            menuCounter.StartPause();
        }
    }
}
