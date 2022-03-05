using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shotPoint;

    [SerializeField] private float startReloadTime;

    private float reloadTime;

    void Update()
    {
        if (reloadTime > 0)
        {
            reloadTime -= Time.deltaTime;
        }
    }

    public void Shoot()
    {
        if (reloadTime <= 0)
        {
            Instantiate(bullet, shotPoint.position, transform.rotation);
            reloadTime = startReloadTime;
        }
    }
}
