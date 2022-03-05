using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class ReloadPresenter : MonoBehaviour
{
    private Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();    
    }

    public void SetReloadIndicator(float value) {
        slider.value = value;
    }
}
