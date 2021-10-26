using UnityEngine;

using House312B.Core;
using House312B.InventorySystem;
using UnityEngine.Assertions;

namespace House312B.Interaction
{
    public class HasItemChecker : MonoBehaviour, IInteractionChecker
    {
        [SerializeField] private ItemData _itemData;

        private Inventory _inventory;
        

        private void Awake()
        {
            _inventory = FindObjectOfType<Inventory>();
            Assert.AreNotEqual(_inventory, null, $"{nameof(AddItemToInventoryAction)} didn't find Inventory");
        }

        public bool CanInteract()
        {
            return _inventory.Has(_itemData);
        }
    }
}