using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace UniversalUnity.Helpers.MonoBehaviourExtenders
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class CachedMonoBehaviour : MonoBehaviour
    {
        private readonly List<Component> _cachedComponents = new List<Component>(0);
        private readonly List<Component> _cachedParentComponents = new List<Component>(0);
        private Transform _transform = null;
        private GameObject _gameObject = null;

        private void OnDestroy()
        {
            _cachedComponents.Clear();
            _cachedParentComponents.Clear();
            _transform = null;
            _gameObject = null;
        }

        public new Transform transform
        {
            get
            {
                if (ReferenceEquals(_transform, null)) _transform = base.transform;
                return _transform;
            }
        }

        public new GameObject gameObject
        {
            get
            {
                if (ReferenceEquals(_gameObject, null)) _gameObject = base.gameObject;
                return _gameObject;
            }
        }

        public new T GetComponent<T>() where T : Component
        {
            T temp = _cachedComponents.Find(o => o is T) as T;
            if (temp == null)
            {
                temp = base.GetComponent<T>();
                _cachedComponents.Add(temp);
                return temp;
            }

            return temp;
        }

        public new T GetComponentInParent<T>() where T : Component
        {
            T temp = _cachedParentComponents.Find(o => o is T) as T;
            if (temp == null)
            {
                temp = base.GetComponent<T>();
                _cachedParentComponents.Add(temp);
                return temp;
            }

            return temp;
        }
    }
}