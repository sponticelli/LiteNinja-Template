using LiteNinja.MonoActions;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.MonoActions
{
    public class NextSceneLoader : MonoBehaviour
    {
        [SerializeField] private LoadSceneAction _loadSceneAction;
        
        private void Start()
        {
            // If only one scene is loaded, then we execute the action
            if (SceneManager.sceneCount == 1)
                _loadSceneAction.Execute();
        }
    }
}