using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
public class TransformFollow : MonoBehaviour
{
    //public event Action<float> GetTransformLink;

    int _indexPlate;
    public GameObject Plate;
    public Transform TransformLink;

    
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(TransformLink.position.x, TransformLink.position.y + 0.1f, TransformLink.position.z), 30f * Time.deltaTime);
    }

}
