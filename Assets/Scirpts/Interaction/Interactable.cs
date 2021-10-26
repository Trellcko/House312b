using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace House312B.Interaction
{
    public class Interactable : SerializedMonoBehaviour
    {
        [SerializeField] private List<InteractionInfo> _interactionInfo;
        [SerializeField] private List<KeyAnimator> _interactionKeyAnimators;

        private bool _isInteracting = false;

        private void Start()
        {
            Assert.AreEqual(_interactionKeyAnimators.Count, _interactionInfo.Count, "Key animatiors count are not equal interaction data count");
            for(int i = 0; i < _interactionInfo.Count; i++)
            {
                _interactionKeyAnimators[i].SetSprite(_interactionInfo[i].Key.Sprite);
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
            ResetActions();


        }

        public void Interact()
        {
            foreach (var interactInfo in _interactionInfo)
            {
                interactInfo.TryDoActions();
            }
        }

        public void ResetActions()
        {
            foreach (var interactInfo in _interactionInfo)
            {
                interactInfo.ResetActions();
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