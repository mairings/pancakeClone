using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace PanCake.Movements
{
    public class BonusManager : MonoBehaviour
    {
        [SerializeField] Transform _foods;
        [SerializeField] Transform[] _parentsBonus;
        List<Transform> _bonusList, _foodList;

        private void Start()
        {
            PanelButtonManager.Instance.SelectType += ImportObjectsList;
            _bonusList = new List<Transform>();
            _foodList = new List<Transform>();
        }

        private void DealOutFood()
        {

            for (int i = 0; i < _foodList.Count; i++)
            {
                _foodList[i].DOMove(_bonusList[i].position, 2f).SetEase(Ease.Linear);
            }
        }

        public void ImportObjectsList(int parent)
        {
            foreach (Transform item in _foods)
            {
                _foodList.Add(item);
            }
            foreach (Transform item in _parentsBonus[parent])
            {
                _bonusList.Add(item);
            }
            DealOutFood();
        }
    }
    
}

