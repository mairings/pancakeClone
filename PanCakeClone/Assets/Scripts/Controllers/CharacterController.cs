using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanCake.Controller
{
    public class CharacterController : MonoBehaviour
    {
        [SerializeField] [Range(0, 10)] float _forwardSpeed;

        public delegate void OnClicked();
        public event OnClicked onClickDown;
        public event OnClicked onClick;
        public event OnClicked onClickUp;


        Vector2 pos1, pos2, delta;
        

        private void Start()
        {
            onClickDown += GetMouseDown;
            onClick += GetMouse;
            onClickUp += GetMouseUp;
        }
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                onClickDown();
            }
            else if (Input.GetMouseButton(0))
            {
                onClick();
            }
            else if (Input.GetMouseButtonUp(0))
            {
                onClickUp();
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
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -0.7f,0.7f),transform.position.y,transform.position.z);
            transform.Translate(-delta.x*10f*Time.deltaTime, 0, _forwardSpeed * Time.deltaTime);
        }
        void GetMouseUp()
        {

        }



    }
}
