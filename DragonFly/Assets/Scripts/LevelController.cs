using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    [SerializeField] private CloudsGenerator cloudsGenerator;
    [SerializeField] private ScoreCounter scoreCounter;
    [SerializeField] private CloudsMove cloudsMove;

    [SerializeField] private float scoreBridge; // Первоначальное значение до след уровня
    [SerializeField] private float minTimeTillSpawn; // Минимальная частота генерации облаков

    [SerializeField] private Text textNum;

    private int level;

    private void FixedUpdate()
    {
        if (scoreCounter.score > scoreBridge)
        {
            scoreBridge += scoreBridge;

            if (cloudsGenerator.timeTillSpawn > minTimeTillSpawn) {
                cloudsGenerator.timeTillSpawn -= 0.5f;
                cloudsMove.movementSpeed += 1f;
                level++;
                textNum.text = level.ToString();
            }
            
        }
    }
}
