using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PanCake.Controllers;
using System;

namespace PanCake.Movements
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] Transform _target;
        [SerializeField] [Range(0, 10)] float _smooth;

        private void Update()
        {
            transform.position = Vector3.Lerp(transform.position, _target.position, _smooth * Time.deltaTime);
        }


    }
}
