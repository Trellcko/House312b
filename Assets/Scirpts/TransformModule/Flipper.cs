using House312B.Core;
using UnityEngine;

namespace House312B.TransformModule
{
    public class Flipper : MonoBehaviour, IFlipper
    {
        [SerializeField] private Transform _transform;

        public void Flip()
        {
            Vector3 theScale = _transform.localScale;
            theScale.x *= -1;
            _transform.localScale = theScale;
        }

    }
}