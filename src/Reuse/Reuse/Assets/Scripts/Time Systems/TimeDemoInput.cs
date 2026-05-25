using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDemoInput : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameEvents.TimeStateRequested(TimeState.Normal);
            Debug.Log("Requested Normal Time.");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GameEvents.TimeStateRequested(TimeState.Slow);
            Debug.Log("Requested Slow Time");
        }
    }
}
