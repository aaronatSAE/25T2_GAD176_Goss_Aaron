using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedCube : MonoBehaviour
{
    [SerializeField] private float movementSpeedInUnitsPerSecond = 1f;

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime
        // If we have our game running at 60 frames per second,
        // deltaTime is 1/60 = 0.0166666666...
        // If our framerate is 600 frames per second,
        // deltaTime is 1/600 = 0.00166666666...
        transform.position = transform.position + transform.forward * Time.deltaTime * movementSpeedInUnitsPerSecond;
    }
}
