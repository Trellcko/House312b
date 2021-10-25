using House312B.Interaction;
using UnityEngine;

namespace House312B.Player
{
    public class Interacting : MonoBehaviour
    {
        private Interactable _interactable;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.TryGetComponent(out _interactable))
            {
                _interactable.EnableInteraction();
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if(_interactable)
            {
                _interactable.DisableInteraction();
                _interactable = null;
            }
        }
    }
}