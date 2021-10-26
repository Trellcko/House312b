using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace House312B.DialogSystem.UI
{
    public class DialogUI : MonoBehaviour
    {
        [field: SerializeField] public DialogUIAnimator Animator { get; private set; }
     
        [SerializeField] private TextMeshProUGUI _textBox;

        [SerializeField] private Transform _attachPoint;

        public void AttachTo(Vector2 position)
        {
            _attachPoint.position = position;
        }

        public void Display(string text)
        {
            _textBox.SetText(text);
        }
    }
}