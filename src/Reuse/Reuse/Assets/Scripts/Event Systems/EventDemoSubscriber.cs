using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDemoSubscriber : MonoBehaviour
{
    void OnEnable()
    {
        GameEvents.OnTimeStateRequested += RespondToTimeEvent;
    }

    void OnDisable()
    {
        GameEvents.OnTimeStateRequested -= RespondToTimeEvent;
    }

    void RespondToTimeEvent(TimeState state)
    {
        Debug.Log(gameObject.name + " received event: " + state);
    }
}
