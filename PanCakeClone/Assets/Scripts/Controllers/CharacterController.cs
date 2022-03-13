using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using PanCake.Abstract.Movements;

namespace PanCake.Controllers
{
    public class CharacterController : MonoBehaviour
    {
        private static CharacterController _instance = null;
        public static CharacterController Instance => _instance;

        [SerializeField] [Range(0, 10)] float _forwardSpeed;

        public delegate void OnClicked();
        public event OnClicked OnClickDown;
        public event OnClicked OnClick;
        public event OnClicked OnClickUp;

        Vector2 pos1, pos2, delta;

        private void Awake()
        {
            _instance = this;
        }

        private void Start()
        {
            OnClickDown += GetMouseDown;
            OnClick += GetMouse;
            OnClickUp += GetMouseUp;  
        }
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                OnClickDown();
            }
            else if (Input.GetMouseButton(0))
            {
                OnClick();
            }
            else if (Input.GetMouseButtonUp(0))
            {
                OnClickUp();
            }
        }

        void GetMouseDown()
        {
            pos1 = new Vector2(Input.mousePosition.x / Screen.width, Input.mousePosition.y / Screen.height);
        }
        void GetMouse()
        {
            pos2 = new Vector2(Input.mousePosition.x / Screen.width, Input.mousePosition.y / Screen.height);
            
            delta = pos1 - pos2;
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -0.7f, 0.7f), transform.position.y, transform.position.z);
            transform.Translate(-delta.x * 10f * Time.deltaTime, 0, _forwardSpeed * Time.deltaTime);
        }
        void GetMouseUp()
        {

        }

    }
}
