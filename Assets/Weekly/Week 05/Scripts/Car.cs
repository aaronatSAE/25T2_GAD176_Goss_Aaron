using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] Rigidbody[] wheels;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        wheels[0].AddTorque(Input.GetAxis("Vertical"), 0, 0);
        wheels[1].AddTorque(Input.GetAxis("Vertical"), 0, 0);
    }
}
