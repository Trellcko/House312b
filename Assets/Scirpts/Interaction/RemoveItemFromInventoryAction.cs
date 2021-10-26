using UnityEngine;
using House312B.Core;
using UnityEngine.Assertions;
using House312B.InventorySystem;

namespace House312B.Interaction
{

    public class RemoveItemFromInventoryAction : MonoBehaviour, IInteractAction
    {
        [SerializeField] private ItemData _itemData;

        private Inventory _inventory;

        private void Awake()
        {
            _inventory = FindObjectOfType<Inventory>();
            Assert.AreNotEqual(_inventory, null, $"{nameof(AddItemToInventoryAction)} didn't find Inventory");
        }

        public void Do()
        {
            _inventory.RemoveItem(_itemData);
        }
    }
}