using House312B.Core;
using UnityEngine;

namespace House312B.Interaction
{
    public class RemoveGameobjectAction : MonoBehaviour, IInteractAction
    {
        [SerializeField] private GameObject _target;
        public void Do()
        {
            Destroy(_target);
        }
    }
}