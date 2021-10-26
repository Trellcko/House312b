using UnityEngine;
using House312B.Core;
using Sirenix.OdinInspector;
using System.Collections.Generic;

namespace House312B.Interaction 
{
    public class InteractionInfo : SerializedMonoBehaviour
    {
        [field: SerializeField] public Key Key { get; }

        [SerializeField] private List<IInteractAction> _actions;
        [SerializeField] private List<IInteractionChecker> _checkers;

        private void Start()
        {
            _checkers.Add(Key);
        }

        public bool TryDoActions()
        {
            foreach (var checer in _checkers)
            {
                if (checer.CanInteract() == false)
                {
                    return false;
                }
            }
            foreach (var action in _actions)
            {
                action.Do();
            }
            return true;

            ;
        }
    }
}