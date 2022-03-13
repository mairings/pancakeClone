using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanCake.Abstract.Movements.Obstacles
{
    public interface IRotate
    {
        void RotateTick(Transform transform, Vector3 direction);

    }

}
