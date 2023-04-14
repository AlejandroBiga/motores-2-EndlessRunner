using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObstacle : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public float[] spawnRates; // The spawn rate of each object in the list
    public float minSpawnTime = 1f;
    public float maxSpawnTime = 3f;

    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            // Choose a random object to spawn
            float totalSpawnRate = 0f;
            for (int i = 0; i < objectsToSpawn.Length; i++)
            {
                totalSpawnRate += spawnRates[i];
            }

            float randomSpawnRate = Random.Range(0f, totalSpawnRate);
            int index = -1;
            while (randomSpawnRate >= 0f)
            {
                index++;
                randomSpawnRate -= spawnRates[index];
            }

            GameObject objectToSpawn = objectsToSpawn[index];

            // Choose a random time delay
            float timeDelay = Random.Range(minSpawnTime, maxSpawnTime);

            // Wait for the specified time delay
            yield return new WaitForSeconds(timeDelay);

            // Spawn the object
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
    }
}
