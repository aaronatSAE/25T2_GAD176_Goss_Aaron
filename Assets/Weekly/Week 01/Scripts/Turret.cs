using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    // We want to rotate while we hold Q and E

    [SerializeField] private float rotationDegreesPerSecond = 1;

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            // Rotate LEFT
            transform.Rotate(0, -rotationDegreesPerSecond, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            // Rotate RIGHT
            transform.Rotate(0, rotationDegreesPerSecond, 0);
        }
    }
}
