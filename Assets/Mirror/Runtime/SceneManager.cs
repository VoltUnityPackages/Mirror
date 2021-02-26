using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mirror
{
    /// <summary>
    ///     <see cref="SceneManager"/> for Mirror
    /// </summary>
    public static class SceneManager
    {
        public delegate void OnBeginSceneLoad(AsyncOperation loadOperation, string sceneLoadingToName);

        /// <summary>
        ///     Invoked when a scene begins loading
        /// </summary>
        public static event OnBeginSceneLoad OnBeginSceneLoading;

        /// <summary>
        ///     Gets the active scene
        /// </summary>
        /// <returns></returns>
        public static Scene GetActiveScene()
        {
            return UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        }

        /// <summary>
        ///     Begins loading a scene asynchronously
        /// </summary>
        /// <param name="sceneName"></param>
        /// <param name="loadMode"></param>
        /// <returns></returns>
        public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode loadMode = LoadSceneMode.Single)
        {
            AsyncOperation operation = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName, loadMode);
            OnBeginSceneLoading?.Invoke(operation, sceneName);

            return operation;
        }

        /// <summary>
        ///     Unloads a scene asynchronously
        /// </summary>
        /// <param name="sceneName"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options)
        {
            return UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName, options);
        }

        /// <summary>
        ///     Gets a <see cref="Scene"/> by its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Scene GetSceneByName(string name)
        {
            return UnityEngine.SceneManagement.SceneManager.GetSceneByName(name);
        }

        /// <summary>
        ///     Gets a <see cref="Scene"/> by its path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Scene GetSceneByPath(string path)
        {
            return UnityEngine.SceneManagement.SceneManager.GetSceneByPath(path);
        }

        public static void MoveGameObjectToScene(GameObject go, Scene scene)
        {
            UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(go, scene);
        }
    }
}
