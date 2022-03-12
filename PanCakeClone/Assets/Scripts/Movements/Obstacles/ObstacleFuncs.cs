using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using PanCake.Abstract.Movements.Obstacles;

namespace PanCake.Movements.Obstacles
{
    public class ObstacleFuncs : IRotate, IMover
    {
       
        public void RotateTick(Transform thisTransform, Vector3 direction)
        {
            thisTransform.Rotate(direction);
        }

        public void MoverTick(Transform thisTransform, Vector3 direction, Vector3 direction2)
        {
            thisTransform.DOLocalMove(direction, 3).OnComplete(() =>
            {
                thisTransform.DOLocalMove(direction2, 3);
            });

        }
       
    }
}

