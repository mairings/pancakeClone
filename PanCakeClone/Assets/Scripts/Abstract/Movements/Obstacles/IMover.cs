using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PanCake.Abstract.Movements.Obstacles
{
    public interface IMover
    {
        void MoverTick(Transform transform,Vector3 directionStart,Vector3 directionFinish);
    }
}

