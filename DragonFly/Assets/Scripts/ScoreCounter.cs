using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private UnityEvent<float> onScoreChanged;

    public float score;

    void Start()
    {
        score = 0;
        StartCoroutine(CountScore());
    }

    private IEnumerator CountScore() {
        while (gameObject.activeSelf) {
            score++;
            onScoreChanged.Invoke(score);
        }

        yield return new WaitForSeconds(1);
    }
}
