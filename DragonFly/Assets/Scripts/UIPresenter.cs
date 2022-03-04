using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPresenter : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text levelText;

    public void UpdateScore(int score) {
        scoreText.text = score.ToString();
    }

    public void UpdateLevel(int level)
    {
        levelText.text = level.ToString();
    }
}
