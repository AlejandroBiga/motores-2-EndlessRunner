using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObstacle : MonoBehaviour
{
    
    // Start is called before the first frame update
    public GameObject objectToSpawn;
    public float minSpawnTime = 1f;
    public float maxSpawnTime = 5f;
    //tiempo de destruccion 
    public float destroyTime = 5f;

    private float nextSpawnTime;

    void Start()
    {
        SetNextSpawnTime();
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();
            SetNextSpawnTime();
        }
    }


    //genera un spawn aleatorio entre el tiempo maximo y el tiempo minimo definidos arriba
    void SetNextSpawnTime()
    {
        nextSpawnTime = Time.time + Random.Range(minSpawnTime, maxSpawnTime);
    }

    void SpawnObject()
    {
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        //destruir el objeto 
        Destroy(spawnedObject, destroyTime);

    }
}
