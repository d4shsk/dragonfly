using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public void LoadPlayScene() {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }    
}
