using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class OnToNextLevel : MonoBehaviour
    {
        [SerializeField] private string _sceneName;

        public void SceneLoad()
        {
            SceneManager.LoadScene(_sceneName);
        }
    }
}
