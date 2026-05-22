using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 1;
    public float lifetime = 5f;

    public GameObject owner;

    [Header("Collision")]
    public bool destroyOnAnyCollision = false;
    public LayerMask hitLayers;

    private float lifeTimer;

    void OnEnable()
    {
        lifeTimer = 0f;
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        lifeTimer += Time.deltaTime;

        if (lifeTimer >= lifetime)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (owner != null && other.transform.root.gameObject == owner)
            return;

        if (!destroyOnAnyCollision)
        {
            bool layerIsValid =
                (hitLayers.value & (1 << other.gameObject.layer)) != 0;

            if (!layerIsValid)
                return;
        }

        Debug.Log("Projectile hit: " + other.gameObject.name);
        Destroy(gameObject);
    }
}