using UnityEngine;
using UnityEngine.Events;

namespace Script.Animation
{
    public class OnClickAnimation : MonoBehaviour
    {
        [SerializeField] private UnityEvent _onComplete;
        
        public void OnMouseDown()
        {
            _onComplete?.Invoke();
        }
    }
}
