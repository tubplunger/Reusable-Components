using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolDemoSpawner : MonoBehaviour
{
    public ObjectPool pool;
    public float spawnRate = 0.25f;
    public float spawnRadius = 3f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            timer = 0f;
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        if (pool == null)
            return;

        Vector3 randomPosition = transform.position + new Vector3(
            Random.Range(-spawnRadius, spawnRadius),
            Random.Range(0f, spawnRadius),
            Random.Range(-spawnRadius, spawnRadius)
        );

        pool.GetObject(randomPosition, Random.rotation);
    }
}
