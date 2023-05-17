using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public delegate void RemovePanel(InfoPanel panel);

    public class FactoryUsersView : MonoBehaviour
    {
        [SerializeField] private InfoClass InfoClass;
        [SerializeField] private InfoPanel panelPrefab;
        [SerializeField] private RectTransform parentPanel;
        private List<InfoPanel> _infoPanels = new();
        private RemovePanel _removePanel;

        private void Start()
        {
            StartCoroutine(PullInfo());
            _removePanel = RemovePanel;
        }

        private IEnumerator PullInfo()
        {
            var result = new WWW($"https://random-data-api.com/api/users/random_user?size=5");
            yield return result;
            InfoClass = JsonUtility.FromJson<InfoClass>("{\"Infos\":" + result.text + "}");
            Debug.Log(result.text);
            foreach (var info in InfoClass.Infos)
            {
                IInit<RemovePanel> initRemovePanel = null;
                var panel = Instantiate(panelPrefab, parentPanel);
                panel.SetInfo(info);
                initRemovePanel = panel;
                initRemovePanel.Initialize(_removePanel);
                _infoPanels.Add(panel);
            }
        }

        private void RemovePanel(InfoPanel panel)
        {
            _infoPanels.Remove(panel);
            if (_infoPanels.Count == 0) StartCoroutine(PullInfo());
        }
    }

    [Serializable]
    public class InfoClass
    {
        public Info[] Infos;
    }

    [Serializable]
    public struct Info
    {
        public int id;
        public string first_name;
        public string last_name;
        public string email;
    }
}