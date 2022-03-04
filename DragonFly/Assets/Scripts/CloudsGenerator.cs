using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsGenerator : MonoBehaviour
{
    public float timeTillSpawn;

    [SerializeField] private GameObject cloud;
    [SerializeField] private ScoreCounter scoreCounter;
    

    void Start()
    {
        timeTillSpawn = 2f;

        StartCoroutine(cloudSpawner());
    }

    private IEnumerator cloudSpawner() {
        while (true) {
            float randomYPos = Random.Range(-4f, 4f);
            GameObject newCloud = Instantiate(cloud, new Vector3(10, randomYPos, 0), Quaternion.identity);

            Destroy(newCloud, 5);
            yield return new WaitForSeconds(timeTillSpawn);
        }
    }
}
