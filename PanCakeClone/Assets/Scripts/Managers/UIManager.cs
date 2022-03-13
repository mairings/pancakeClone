using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using PanCake.Movements;

namespace PanCake.Managers
{
    public class UIManager : MonoBehaviour
    {
        private static UIManager _instance = null;
        public static UIManager Instance => _instance;

        [SerializeField] GameObject ComplatePanelObj, FailedPanelObj;

        private void Awake()
        {
            _instance = this;
        }

        public void FailedPanelFunc()
        {
            if (ComplatePanelObj.activeSelf == true) return;
            FailedPanelObj.SetActive(true);
        }

        public void ComplatePanelFunc()
        {
            if (FailedPanelObj.activeSelf == true) return;
            ComplatePanelObj.SetActive(true);
        }


    }
}

