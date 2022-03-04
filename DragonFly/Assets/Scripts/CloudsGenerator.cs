using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsGenerator : MonoBehaviour
{
    [SerializeField] private float timeTillSpawn;
    [SerializeField] private float minTimeTillSpawn; // Минимальная частота генерации облаков

    [SerializeField] private GameObject cloud;
    

    void Start()
    {
        StartCoroutine(SpawnClouds());
    }

    private IEnumerator SpawnClouds() {
        while (true) {
            float randomYPos = Random.Range(-4f, 4f);
            GameObject newCloud = Instantiate(cloud, new Vector3(10, randomYPos, 0), Quaternion.identity);

            Destroy(newCloud, 5);
            yield return new WaitForSeconds(timeTillSpawn);
        }
    }

    public void DecreaseTimeTillSpawn(float size) {
        if (timeTillSpawn > minTimeTillSpawn)
        {
            timeTillSpawn -= size;
        }
    }
}
