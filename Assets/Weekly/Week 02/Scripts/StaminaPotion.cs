using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGrandAlchemistGame
{
    public class StaminaPotion : MonoBehaviour
    {
        // We need some PROPERTIES
        // Has an potency, which specifies how much it heals or boosts.
        private int potency = 0;
        // Has a sellValue, which determines how much gold you can sell
        // it for.
        private int sellValue = 0;

        // We need some FUNCTIONALITY
        // Can be used, which grants the player more stamina and then
        // removes the item from the inventory.

        public void Consume()
        {
            // Add stamina to the player; an amount equal to potency
            Debug.Log("Potion consumed! " + gameObject.name);
        }
    }
}
