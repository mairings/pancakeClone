using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PanCake.Managers
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance = null;
        public static GameManager Instance => _instance;

        private void Awake()
        {
            _instance = this;
        }

        void StopGame()
        {
            Time.timeScale = 0;
        }

        void StarGame()
        {
            Time.timeScale = 1;
        }

        void LoadScene(string sceneName)
        {
            SceneManager.LoadSceneAsync(sceneName);
        }

        public void ExitGame()
        {
            Debug.Log("Exit On Clicked");
            Application.Quit();
        }

        public void RestartGame()
        {
            LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}

