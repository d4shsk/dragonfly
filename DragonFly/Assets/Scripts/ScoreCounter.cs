using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreCounter : MonoBehaviour
{
    public float score;
    private Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
        score = 0;
    }

    void Update()
    {
        score += Time.deltaTime;
        scoreText.text = ((int) score).ToString();
    }
}
