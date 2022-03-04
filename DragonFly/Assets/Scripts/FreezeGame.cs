using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeGame : MonoBehaviour
{
    public void Freeze() {
        Time.timeScale = 0;
    }

    public void UnFreeze() {
        Time.timeScale = 1;
    }
}
