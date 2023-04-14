using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObstacle : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
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
            int index = Random.Range(0, objectsToSpawn.Length);
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
