using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Collect : MonoBehaviour
{

    public List<Transform> CollectedList = new List<Transform>();
    delegate void CollectFoods(Collision collision);
    event CollectFoods collectFoods;

    private void Start()
    {
        collectFoods += CollectFoodFunc;
        CollectedList.Add(this.transform);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Collectible")
        {
            collectFoods?.Invoke(collision);
        }
      
    }


    private void CollectFoodFunc(Collision collision)
    {
        collision.collider.GetComponent<BoxCollider>().enabled = false;
        collision.collider.gameObject.AddComponent<TransformFollow>();
        collision.collider.GetComponent<Rigidbody>().isKinematic = true;
        collision.collider.GetComponent<TransformFollow>().TransformLink = CollectedList.Last();
        CollectedList.Add(collision.collider.gameObject.transform);
        collision.collider.GetComponent<TransformFollow>().Plate = this.gameObject;
    }

    



}
