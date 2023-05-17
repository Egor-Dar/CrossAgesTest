using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class InfoPanel : MonoBehaviour, IInit<RemovePanel>
    {
        [SerializeField] private TextMeshProUGUI id;
        [SerializeField] private TextMeshProUGUI firstAndLastName;
        [SerializeField] private TextMeshProUGUI emailName;
        [SerializeField] private Button deleteButton;
        [SerializeField] private CanvasGroup canvasGroup;
        private Transform _mTransform;
        private event RemovePanel _removePanel;

        private void Awake()
        {
            _mTransform = transform;
        }

        public void SetInfo(Info info)
        {
            id.text = info.id.ToString();
            firstAndLastName.text = info.first_name + " " + info.last_name;
            emailName.text = info.email;
            var currentScale = transform.localScale;
            _mTransform.localScale = Vector3.zero;
            transform.DOScale(currentScale, 0.4f);
            canvasGroup.DOFade(1, 0.3f);
            deleteButton.onClick.AddListener(()=>Destroy() );
        }

        private void Destroy()
        {
            _removePanel?.Invoke(this);
            transform.DOScale(Vector3.zero, 0.4f).OnComplete((() => Destroy(gameObject)));
            canvasGroup.DOFade(0, 0.3f);
        }

        public void Initialize(RemovePanel subscribe)
        {
            _removePanel += subscribe;
        }
    }
}