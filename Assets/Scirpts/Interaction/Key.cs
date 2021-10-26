using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

using House312B.Core;

namespace House312B.Interaction
{
    [CreateAssetMenu(fileName = "new Key", menuName = "Interaction/Key", order = 41)]
    public class Key : ScriptableObject, IInteractionChecker
    {
        [field: SerializeField] public Sprite Sprite { get; private set; }
        [SerializeField] private KeyCode _keyCode;

        private KeyControl _keyControll;

        public bool CanInteract()
        {
            _keyControll ??=  Keyboard.current.FindKeyOnCurrentKeyboardLayout(_keyCode.ToString());
            Assert.AreNotEqual(_keyControll, null, $"Didn't find key with name {_keyCode}");

            return _keyControll.wasPressedThisFrame;
        }
    }
}