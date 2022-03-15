using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using PanCake.Managers;
namespace PanCake.Movements
{
    public class PanelButtonManager : MonoBehaviour
    {
        static PanelButtonManager _instance = null;
        public static PanelButtonManager Instance => _instance;

        public event Action<int> SelectType;

        
        private void Awake()
        {
            _instance = this;
        }

        public void SelectHorizontalFunc(int parent)
        {
            SelectType?.Invoke(parent);
        }

        public void RestartScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
