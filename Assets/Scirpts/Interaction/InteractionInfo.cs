using UnityEngine;
using House312B.Core;
using Sirenix.OdinInspector;

namespace House312B.Interaction 
{
    public class InteractionInfo : SerializedMonoBehaviour
    {
        [field: SerializeField] public Sprite KeySprite { get; }
        [field: SerializeField] public IInteractAction Action { get; }
    }
}