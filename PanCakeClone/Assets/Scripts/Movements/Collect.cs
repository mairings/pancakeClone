using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Collect : MonoBehaviour
{

    public List<Transform> CollectedList = new List<Transform>();

    private void Start()
    {
        CollectedList.Add(this.transform);
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Collectible")
    //    {
    //        other.GetComponent<BoxCollider>().enabled = false;
    //        Kat += 0.1f;
    //        other.gameObject.AddComponent<TransformFollow>();
    //        other.GetComponent<Rigidbody>().isKinematic = true;
    //        other.GetComponent<TransformFollow>().TransformLink = CollectedList.Last();
    //        CollectedList.Add(other.gameObject.transform);
    //        other.GetComponent<TransformFollow>().Plate = this.gameObject;


    //    }

    //}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Collectible")
        {

            collision.collider.GetComponent<BoxCollider>().enabled = false;
            collision.collider.gameObject.AddComponent<TransformFollow>();
            collision.collider.GetComponent<Rigidbody>().isKinematic = true;
            collision.collider.GetComponent<TransformFollow>().TransformLink = CollectedList.Last();
            CollectedList.Add(collision.collider.gameObject.transform);
            collision.collider.GetComponent<TransformFollow>().Plate = this.gameObject;
        }
    }



}
