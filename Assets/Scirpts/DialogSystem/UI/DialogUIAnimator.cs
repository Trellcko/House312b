using UnityEngine;

namespace House312B.DialogSystem.UI
{
    public class DialogUIAnimator : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        private const string ShowTriggerName = "Show";
        private const string HideTriggerName = "Hide";

        public void Show()
        {
            _animator.SetTrigger(ShowTriggerName);
        }
        public void Hide()
        {
            _animator.SetTrigger(HideTriggerName);
        }
            
    }
}