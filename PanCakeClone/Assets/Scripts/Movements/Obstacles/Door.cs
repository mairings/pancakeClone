using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using PanCake.Managers;

namespace PanCake.Movements
{
    public class Door : MonoBehaviour
    {
        [SerializeField] GameObject _door;

        delegate void ObstacleOpenDoor();
        event ObstacleOpenDoor _openDoor;

        private void Start()
        {
            _openDoor += OpenDoorFunc;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name == "Plate")
            {
                _openDoor?.Invoke();
            }
        }

        public void OpenDoorFunc()
        {
            transform.DOLocalMoveY(0.34f, 0.5f).OnComplete(() =>
            {
                _door.transform.DOMoveY(-1, 0.5f);
            });
        }


    }
}

