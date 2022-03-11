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

    float _kat;

    private void Start()
    {
        _kat = Plate.GetComponent<Collect>().Kat;

    }
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(TransformLink.position.x, _kat, TransformLink.position.z), 30f * Time.deltaTime);
    }

}
