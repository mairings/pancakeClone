using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using PanCake.Abstract.Movements.Obstacles;
using PanCake.Movements.Obstacles;

namespace PanCake.Movements.Obstacles
{
    public class Rotate :  MonoBehaviour
    {
        public Vector3 _rotateDirection;
        IRotate _rotate;

        private void Awake()
        {
            _rotate = new ObstacleFuncs();
        }
        private void FixedUpdate()
        {
            _rotate.RotateTick(transform, _rotateDirection);

        }
        
    }
}

