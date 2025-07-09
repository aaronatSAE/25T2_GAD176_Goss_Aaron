using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGrandAlchemistGame
{
    public class Inventory : MonoBehaviour
    {
        // Can hold a collection of potions
        [SerializeField] private StaminaPotion[] potions;

        // Can hold a collection of items
        [SerializeField] private Item[] items = new Item[8];

        // Can drink certain potions from the potions array

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (items[0] != null)
                {
                    items[0].AnnounceNameInConsole();
                }
            }
        }

        public void ConsumePotion()
        {
            potions[0].Consume();
        }
    }
}
