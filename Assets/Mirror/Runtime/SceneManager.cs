using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mirror
{
    public static class SceneManager
    {
        public delegate void OnBeginSceneLoad(AsyncOperation loadOperation);

        public static event OnBeginSceneLoad OnBeginSceneLoading;

        public static Scene GetActiveScene()
        {
            return UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        }

        public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode loadMode = LoadSceneMode.Single)
        {
            AsyncOperation operation = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName, loadMode);
            OnBeginSceneLoading?.Invoke(operation);

            return operation;
        }

        public static AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options)
        {
            return UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName, options);
        }

        public static Scene GetSceneByName(string name)
        {
            return UnityEngine.SceneManagement.SceneManager.GetSceneByName(name);
        }

        public static Scene GetSceneByPath(string path)
        {
            return UnityEngine.SceneManagement.SceneManager.GetSceneByPath(path);
        }
    }
}
