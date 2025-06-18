using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGrandAlchemistGame
{
    public class Coin : MonoBehaviour, ICollectable
    {
        public void Collect()
        {
            Debug.Log("Collected a coin!");
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}