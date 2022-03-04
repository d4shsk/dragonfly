using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndGame : MonoBehaviour
{
    [SerializeField] private UnityEvent onGameEnded;

    public static bool restart;
    [SerializeField] MenuController menuCounter;

    private void Start()
    {
        restart = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            onGameEnded.Invoke();
            restart = true;
            menuCounter.StartPause();
        }
    }
}
