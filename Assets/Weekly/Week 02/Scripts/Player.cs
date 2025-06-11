using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGrandAlchemistGame
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private int stamina;

        [SerializeField] private Inventory inventory;

        // When the player presses spacebar,
        // activate the first item in the inventory.

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Activate the first item in the inventory.
                inventory.ConsumePotion();
            }
        }

        public void AddStamina()
        {
            stamina += 10;
        }
    }
}
