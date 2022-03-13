using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;
using PanCake.Managers;

namespace PanCake.Movements
{
    public class Finish : MonoBehaviour
    {
        delegate void FinishEvents(Collider other);
        event FinishEvents _eatFood;

        private void Start()
        {
            _eatFood += EatFunc;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.name == "Plate")
            {
                _eatFood?.Invoke(collision.collider);
                Debug.Log("bitti");
            }
        }

        private void EatFunc(Collider other)
        {
            foreach (Transform item in other.GetComponent<Collect>().CollectedList)
            {
                if (item.name != "Plate")
                {
                    //item.GetComponent<BoxCollider>().isTrigger = false;
                    item.GetComponent<TransformFollow>().enabled = false;
                    item.tag = "Untagged";
                    item.GetComponent<BoxCollider>().enabled = true;
                    item.transform.DOMove(transform.GetChild(2).transform.position, 2f);
                    UIManager.Instance.ComplatePanelFunc();
                }
                
            }
        }
    }
}

