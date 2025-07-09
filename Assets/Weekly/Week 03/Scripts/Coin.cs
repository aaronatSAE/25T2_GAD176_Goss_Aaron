using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGrandAlchemistGame
{
    public class Coin : Treasure, ICollectable
    {
        public void Collect()
        {
            Debug.Log("Collected a coin!");
        }

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("This coin is worth " + valueInGold + " gold coins.");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}