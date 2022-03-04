using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class MenuController : MonoBehaviour
{
    [SerializeField] private UnityEvent onPauseStarted;
    [SerializeField] private UnityEvent onPauseStopped;
    [SerializeField] private UnityEvent onLoadingStartMenu;

    [SerializeField] GameObject pauseCanvas;

    void Start()
    {
        pauseCanvas.SetActive(false);
    }


    public void StartPause() {
        onPauseStarted.Invoke();
        pauseCanvas.SetActive(true);
    }

    public void StopPause()
    {
        onPauseStopped.Invoke();

        if (!EndGame.restart)
        {
            pauseCanvas.SetActive(false);
        }
        else {
            SceneManager.LoadScene(1); // Надо потом убрать
        }
    }

    public void GoToStartMenu() {

        onLoadingStartMenu.Invoke();

        SceneManager.LoadScene(0);
    }
}
