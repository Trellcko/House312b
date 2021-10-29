using UnityEngine;
using UnityEngine.InputSystem;
using House312B.Input;
using Sirenix.OdinInspector;
using House312B.Core;
using House312B.Utils;

namespace House312B.Player
{
    public class Movement : SerializedMonoBehaviour 
    {
        [SerializeField] private IMover _mover;

        private float _xInput = 0f;

        private void Start()
        {
            QuickAssert.AssertIsNotNullAfterAssigment(_mover);
        }


        private void OnEnable()
        {
            InputHandler.Instace.PlayerMovement.performed += Move;
            InputHandler.Instace.PlayerMovement.canceled += StopMoving;
        }

        private void OnDisable()
        {
            InputHandler.Instace.PlayerMovement.performed -= Move;
            InputHandler.Instace.PlayerMovement.canceled -= StopMoving;
        }

        private void FixedUpdate()
        {
            _mover.Move(new Vector2(_xInput, 0));
        }

        private void StopMoving(InputAction.CallbackContext callBack)
        {
            _xInput = 0;
        }

        private void Move(InputAction.CallbackContext callBack)
        {
            _xInput = callBack.ReadValue<float>();
        }
    }
}