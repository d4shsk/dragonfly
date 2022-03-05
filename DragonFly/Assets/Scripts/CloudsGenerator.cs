using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsGenerator : MonoBehaviour
{
    [SerializeField] private float timeTillSpawn;
    [SerializeField] private float minTimeTillSpawn; // Минимальная частота генерации облаков
    [SerializeField] private float lifetime;
    [SerializeField] private GameObject cloud;

    [SerializeField] private int cloudAmount;

    void Start()
    {
        StartCoroutine(SpawnClouds());
    }

    private IEnumerator SpawnClouds() {
        while (true) { // потом убрать вайл тру
            CreateClouds(cloudAmount);
            yield return new WaitForSeconds(timeTillSpawn);
        }
    }

    private void CreateClouds(int amount) {
        for (int i = 0; i < amount; i++) {
            float randomYPos = Random.Range(-4f, 4f);
            float randomXPos = Random.Range(10f, 15f);
            GameObject newCloud = Instantiate(cloud, new Vector3(randomXPos, randomYPos, 0), Quaternion.identity);
            Destroy(newCloud, lifetime);
        }
    }

    public void IncreaseSpawningAmount(int level) {
        if (level == 5 || level == 3 || level == 15) {
            cloudAmount++;
        }
    }

    public void DecreaseTimeTillSpawn(float size) {
        if (timeTillSpawn > minTimeTillSpawn)
        {
            timeTillSpawn -= size;
        }
    }
}
