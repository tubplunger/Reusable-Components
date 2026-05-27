using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITargetDemoMover : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(x, 0f, z).normalized;

        transform.position += move * moveSpeed * Time.deltaTime;
    }
}
