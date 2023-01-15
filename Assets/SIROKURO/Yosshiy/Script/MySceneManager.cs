using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Manager
{
    sealed class MySceneManager : MonoBehaviour
    {
        public void LoadAddtive(string scenename)
        {
            SceneManager.LoadSceneAsync(scenename, LoadSceneMode.Additive);
        }

        public void UnLoadScene(string scenename)
        {
            SceneManager.UnloadSceneAsync(scenename);
        }

    }
}
