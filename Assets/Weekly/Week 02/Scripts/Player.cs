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

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("You have collided with SOMETHING!");
            // Check that we have collided with a POTION
            if (other.CompareTag("Potion") == true)
            {
                // We HAVE hit a potion! Do the thing
                // refer to the potion
                // do the "Collect()"
                Debug.Log("You have collided with a potion!");
                other.GetComponent<StaminaPotion>().Collect();
            }
        }

        public void AddStamina()
        {
            stamina += 10;
        }
    }
}
