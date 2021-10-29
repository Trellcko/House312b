using House312B.Input;
using UnityEngine;
using House312B.Animation;
using House312B.Utils;

namespace House312B.Player
{
    public class AnimatorHandler : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        private MoveAnimation _moveAnimation;

        private void Start()
        {
            QuickAssert.AssertIsNotNullAfterAssigment(_animator);
            _moveAnimation = new MoveAnimation(_animator);
        }

        private void OnEnable()
        {
            InputHandler.Instace.PlayerMovement.performed += OnPlayerMovementPerformed;
            InputHandler.Instace.PlayerMovement.canceled += OnPlayerMovementCanceled;
        }
        private void OnDisable()
        {
            InputHandler.Instace.PlayerMovement.performed -= OnPlayerMovementPerformed;
            InputHandler.Instace.PlayerMovement.canceled -= OnPlayerMovementCanceled;
        }


        private void OnPlayerMovementCanceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _moveAnimation.PlayIdleAnimation();
        }

        private void OnPlayerMovementPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _moveAnimation.PlayWalkAnimation();
        }

    }
}