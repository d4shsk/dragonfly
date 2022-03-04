using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatisticSaves : MonoBehaviour
{
    [SerializeField] ScoreCounter scoreCounter;

    public void SaveScore() {
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
    }
}
