using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Collect : MonoBehaviour
{

    public float Kat;
    public List<Transform> CollectedList = new List<Transform>();

    private void Start()
    {
        CollectedList.Add(this.transform);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Collectible")
        {
            other.GetComponent<BoxCollider>().enabled = false;
            Kat += 0.1f;
            other.gameObject.AddComponent<TransformFollow>();
            other.GetComponent<TransformFollow>().TransformLink = CollectedList.Last();
            CollectedList.Add(other.gameObject.transform);
            other.GetComponent<TransformFollow>().Plate = this.gameObject;
        }
 
    }


        
  }
