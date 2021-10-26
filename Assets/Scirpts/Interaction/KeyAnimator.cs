using UnityEngine;

namespace House312B.Interaction
{
    public class KeyAnimator : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private SpriteRenderer _spriteRenderer;

        private const string ShowTriggerName = "Show";
        private const string HideTriggerName = "Hide";

        public void SetSprite(Sprite sprite)
        {
            _spriteRenderer.sprite = sprite;
        }

        public void PlayShowAnimation()
        {
            _animator.SetTrigger(ShowTriggerName);
        }

        public void PlayHideAnimation()
        {
            _animator.SetTrigger(HideTriggerName);
        }
    }
}