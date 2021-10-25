using House312B.Core;
using UnityEngine;
using UnityEngine.InputSystem;

namespace House312B.Interaction
{
    public class TestInteractionAction : MonoBehaviour, IInteractAction
    {
        public bool TryDo()
        {
            if(Keyboard.current.dKey.wasPressedThisFrame)
            {
                Debug.Log("Test Interaction");
                return true;
            }
            return false;
        }
    }
}