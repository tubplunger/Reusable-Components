using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolDemoAutoReturn : MonoBehaviour
{
    public float lifetime = 2f;

    private float timer;
    private PooledObject pooledObject;

    void Awake()
    {
        pooledObject = GetComponent<PooledObject>();
    }

    void OnEnable()
    {
        timer = 0f;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= lifetime)
        {
            pooledObject.ReturnToPool();
        }
    }
}