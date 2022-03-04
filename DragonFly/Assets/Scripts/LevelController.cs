using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class LevelController : MonoBehaviour
{
    [SerializeField] private UnityEvent onNewLevel;

    [SerializeField] private CloudsGenerator cloudsGenerator;
    [SerializeField] private ScoreCounter scoreCounter;

    [SerializeField] private float scoreBridge; // Первоначальное значение до след уровня
    

    [SerializeField] private Text textNum;

    private int level;

    private void FixedUpdate()
    {
        if (scoreCounter.score > scoreBridge)
        {
            scoreBridge += scoreBridge;
            onNewLevel.Invoke();
            textNum.text = level.ToString();
            level++;
        }
    }
}
