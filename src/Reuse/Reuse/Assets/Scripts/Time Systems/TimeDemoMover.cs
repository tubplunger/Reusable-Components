using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDemoMover : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float resetX = 5f;
    public float startX = -5f;

    void Update()
    {
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;

        if (transform.position.x >= resetX)
        {
            transform.position = new Vector3(
                startX,
                transform.position.y,
                transform.position.z
            );
        }
    }
}
