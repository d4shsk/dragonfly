using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class LevelController : MonoBehaviour
{
    [SerializeField] private UnityEvent<int> onNewLevel;
    [SerializeField] private float scoreBridge; // Первоначальное значение до след уровня
    [SerializeField] private float nextScoreBridge;

    private int level = 0;

    public void ApplyNewLevel(int score) {
        if (score == scoreBridge)
        {
            level++;
            onNewLevel.Invoke(level);
            scoreBridge += nextScoreBridge;
        }
    }
}
