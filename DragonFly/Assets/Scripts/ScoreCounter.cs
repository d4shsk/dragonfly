using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private UnityEvent<int> onScoreChanged;

    public int score;

    private void Start()
    {
        score = 0;
        StartCoroutine(CountScore());
    }

    private IEnumerator CountScore() {
        while (true) {
            score++;
            onScoreChanged.Invoke(score);
            yield return new WaitForSeconds(1);
        }
    }
}
