using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Architecture
{
    public class Cell : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private SpriteRenderer sprite;
        private Transform _mTransform;
        private const float START_VALUE_Z_POSITION = 0.5f;
        private const int END_VALUE_Z_POSITION = 2;
        private void Awake()
        {
            _mTransform = transform;
        }

        public void SetPositionCell(Vector3 position)
        {
            _mTransform.position = position;
        }
        
        
        public void OnPointerClick(PointerEventData eventData)
        {
            DOTween.Sequence().Append(

                  _mTransform.DOMoveZ(END_VALUE_Z_POSITION, 0.3f).OnComplete(()=>_mTransform.DOMoveZ(START_VALUE_Z_POSITION, 0.1f)));
                 _mTransform.DOScale(Vector3.one * 2, 0.3f).OnComplete((() => _mTransform.DOScale(Vector3.one, 0.1f)));
        }

        private void OnMouseEnter()
        {
            sprite.color = Color.cyan;
        }

        private void OnMouseExit()
        {
            sprite.color = Color.white;
        }
    }
}