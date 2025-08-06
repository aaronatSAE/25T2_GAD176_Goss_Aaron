using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StealthO.SightDetection
{
    public class CameraFieldOfView : FieldOfView
    {
        public override void PowerOff()
        {
            throw new System.NotImplementedException();
        }

        public override void PowerOn()
        {
            throw new System.NotImplementedException();
        }

        public override void Scan()
        {
            // Do a raycast
            Debug.Log("Scan!");
        }

        public override void SelfDestruct()
        {
            throw new System.NotImplementedException();
        }

        private void Start()
        {
            PowerOn();
        }

        //private void Update()
        //{
        //    Debug.Log("Yoooooo from CAMERA derived class!");
        //}
    }
}
