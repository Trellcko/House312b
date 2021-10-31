using UnityEngine;
using House312B.Core;
using House312B.Player;



namespace House312B.Interaction
{
    public class TurnOffPlayerInput : MonoBehaviour, IAction
    {
        private AnimatorHandler _animatorHandler;
        private Movement _movement;
        private AudioPlayer _audio;

        private void Awake()
        {
            _animatorHandler = FindObjectOfType<AnimatorHandler>();
            _movement = FindObjectOfType<Movement>();
            _audio = FindObjectOfType<AudioPlayer>();
        }

        public void Do()
        {
            _animatorHandler.UnSubscribe();
            _movement.UnSubscribe();
            _audio.UnSubscibe();
            _audio.StopPlayMovementSound();
        }
    }
}