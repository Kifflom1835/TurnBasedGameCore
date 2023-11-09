using UnityEngine;

namespace UniversalUnity.Helpers.MonoBehaviourExtenders
{
    /// <summary>
    /// simple class to keep GameObject when loading other scenes
    /// </summary>
    public sealed class DontDestroy : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}