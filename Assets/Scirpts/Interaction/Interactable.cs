using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace House312B.Interaction
{
    public class Interactable : SerializedMonoBehaviour
    {
        [SerializeField] private List<InteractionInfo> _interactionData;
        [SerializeField] private List<InteractionKeyAnimator> _interactionKeyAnimators;

        private bool _isInteracting = false;

        private void Start()
        {
            Assert.AreEqual(_interactionKeyAnimators.Count, _interactionData.Count, "Key animatiors count are not equal interaction data count");
            for(int i = 0; i < _interactionData.Count; i++)
            {
                _interactionKeyAnimators[i].SetSprite(_interactionData[i].KeySprite);
            }
        }

        public void Update()
        {
            if (_isInteracting)
            {
                Interact();
            }
        }

        public void EnableInteraction()
        {
            _isInteracting = true;
            ShowInteractionKeysImage();
        }

        public void DisableInteraction()
        {
            _isInteracting = false;
            HideInteractionKeysImage();
        }

        public void Interact()
        {
            foreach (var interactData in _interactionData)
            {
                interactData.Action.TryDo();
            }
        }

        private void ShowInteractionKeysImage()
        {
            foreach (var interactionKey in _interactionKeyAnimators)
            {
                interactionKey.PlayShowAnimation();
            }
        }

        private void HideInteractionKeysImage()
        {
            foreach (var interactionKey in _interactionKeyAnimators)
            {
                interactionKey.PlayHideAnimation();
            }
        }
    }
}