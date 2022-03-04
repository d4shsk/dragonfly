using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayBestScore : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    void OnEnable()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            float loadedScore = PlayerPrefs.GetFloat("Score");
            scoreText.text = ((int) loadedScore).ToString();
        }

        else
        {
            scoreText.text = "0";
        }
    }
}
