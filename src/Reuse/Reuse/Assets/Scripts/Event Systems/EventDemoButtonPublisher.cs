using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDemoButtonPublisher : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameEvents.TimeStateRequested(TimeState.Slow);
            Debug.Log("Publisher: requested slow time event");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            GameEvents.TimeStateRequested(TimeState.Normal);
            Debug.Log("Publisher: requested normal time event");
        }
    }
}