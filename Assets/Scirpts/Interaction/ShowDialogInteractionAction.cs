using House312B.DialogSystem;
using House312B.Core;
using UnityEngine;

namespace House312B.Interaction
{
    public class ShowDialogInteractionAction : MonoBehaviour, IInteractAction
    {
        [SerializeField] private Dialog _dialog;

        public void Do()
        {
            _dialog.ShowNext();
        }

        public void Reset()
        {
            _dialog.ResetIndex();
        }
    }
}