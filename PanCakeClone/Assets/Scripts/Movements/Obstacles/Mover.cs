using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PanCake.Abstract.Movements.Obstacles;
using PanCake.Movements.Obstacles;


namespace PanCake.Movements.Obstacles
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] Vector3 _moveDirectionStart, _moveDirectionFinish;
        IMover _mover;

        private void Awake()
        {
            _mover = new ObstacleFuncs();
        }
        private void Start()
        {
            InvokeRepeating("GoMoveFunc", 0, 6);
        }

        void GoMoveFunc()
        {
            _mover.MoverTick(this.transform, _moveDirectionStart, _moveDirectionFinish);
        }


    }
}

