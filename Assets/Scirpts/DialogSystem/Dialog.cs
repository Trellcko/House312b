using House312B.DialogSystem.UI;
using System.Collections.Generic;
using UnityEngine;

namespace House312B.DialogSystem
{
    public class Dialog : MonoBehaviour
    {
        [SerializeField] private List<DialogInfo> _replics;
        [SerializeField] private DialogUI _dialogUI;

        private int _index = 0;

        public void ResetIndex()
        {
            _index = 0;
        }

        public void ShowNext()
        {
            _dialogUI.AttachTo(_replics[_index].Point.position);
            _dialogUI.Display(_replics[_index].Text);
            _index = _index + 1 == _replics.Count ? 0 : _index + 1;
        }
    }
}