using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using PanCake.Managers;

namespace PanCake.Movements
{
    public class CrashObstacle : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Obstacle")
            {
                foreach (Transform item in GetComponent<Collect>().CollectedList)
                {
                    if (item.name != "Plate")
                    {
                        item.GetComponent<Rigidbody>().isKinematic = false;
                        item.GetComponent<BoxCollider>().isTrigger = false;
                        item.GetComponent<TransformFollow>().enabled = false;
                        item.tag = "Untagged";
                        item.GetComponent<BoxCollider>().enabled = true;
                    }
                }
                
                for (int i = 1; i < GetComponent<Collect>().CollectedList.Count; i++)
                {
                    GetComponent<Collect>().CollectedList.RemoveRange(i, GetComponent<Collect>().CollectedList.Count - 1);
                }
               
            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.tag == "Door")
            {
                Debug.Log("kapýya degdim");
                UIManager.Instance.FailedPanelFunc();
            }
        }
    }
}

