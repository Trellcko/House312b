using House312B.Core;
using UnityEngine;
using UnityEngine.InputSystem;

namespace House312B.Interaction
{
    public class TestInteractionAction : MonoBehaviour, IInteractAction
    {
        public void Do()
        {
            Debug.Log("Test Interaction");
        }
    }
}