using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gun : MonoBehaviour
{
    [SerializeField] private UnityEvent<float> onReloadTimeChanged;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shotPoint;

    [SerializeField] private float startReloadTime;

    private float reloadTime;

    void Update()
    {
        if (reloadTime > 0)
        {
            reloadTime -= Time.deltaTime;

            float timeLeft = startReloadTime - reloadTime;

            onReloadTimeChanged.Invoke(timeLeft);
        }

        if (reloadTime <= 0) {
            Shoot();
        }
    }

    public void Shoot()
    {
        Instantiate(bullet, shotPoint.position, transform.rotation);
        reloadTime = startReloadTime;
    }
}
