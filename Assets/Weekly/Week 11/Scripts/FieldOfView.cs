using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StealthO.SightDetection
{
    public abstract class FieldOfView : MonoBehaviour
    {
        public abstract void Scan();
        public abstract void SelfDestruct();
        public abstract void PowerOn();
        public abstract void PowerOff();

        //private void Update()
        //{
        //    Debug.Log("Hello from base class!");
        //}
    }
}
