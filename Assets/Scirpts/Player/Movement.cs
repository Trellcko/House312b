using UnityEngine;
using UnityEngine.InputSystem;
using House312B.Input;
using Sirenix.OdinInspector;
using House312B.Core;

namespace House312B.Player
{
    public class Movement : SerializedMonoBehaviour 
    {
        [SerializeField] private IMover _mover;

        private float _speed = 0f;
        
        private void OnEnable()
        {
            InputHandler.Instace.PlayerMovemt.performed += Move;
            InputHandler.Instace.PlayerMovemt.canceled += StopMoving;
        }

        private void OnDisable()
        {
            InputHandler.Instace.PlayerMovemt.performed -= Move;
            InputHandler.Instace.PlayerMovemt.canceled -= StopMoving;
        }

        private void FixedUpdate()
        {
            _mover.Move(new Vector2(_speed, 0));
        }

        private void StopMoving(InputAction.CallbackContext callBack)
        {
            _speed = 0;
        }

        private void Move(InputAction.CallbackContext callBack)
        {
            _speed = callBack.ReadValue<float>();
        }
    }
}