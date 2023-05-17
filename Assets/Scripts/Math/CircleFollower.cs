using UnityEngine;

namespace Math
{
    public class CircleFollower : MonoBehaviour
    {
        [SerializeField] private float radius = 2.0f;
        [SerializeField] private Transform point;
        private Vector3 _startPosition;
        private Camera _mainCamera;

        private void Start()
        {
            _startPosition = transform.position;
            _mainCamera = Camera.main;
        }

        private void Update()
        {
            var mousePos = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0.0f;

            var distance = Vector3.Distance(mousePos, _startPosition);

            if (distance > radius)
            {
                var direction = mousePos - _startPosition;
                direction.Normalize();
                point.position = _startPosition + direction * radius;
            }
            else
            {
                point.position = mousePos;
            }
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.white;
            Gizmos.DrawWireSphere(transform.position, radius);
        }
    }
}