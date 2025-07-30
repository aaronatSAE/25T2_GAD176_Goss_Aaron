using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGrandAlchemistGame
{
    public class Gemstone : Treasure, ICollectable
    {
        private void Start()
        {
            HologramEvents.onSpacebarPressed?.Invoke();
        }

        public void Collect()
        {
            Debug.Log("Collected a gemstone!");
        }
    }
}
