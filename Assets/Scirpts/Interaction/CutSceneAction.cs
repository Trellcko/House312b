using House312B.Core;
using Sirenix.OdinInspector;
using UnityEngine;

namespace House312B.Interaction
{
    public class CutSceneAction : SerializedMonoBehaviour
    {
        [field: SerializeField] public IAction Action { get; private set; }
        [field: SerializeField] public float Duration { get; private set; }
    }
}