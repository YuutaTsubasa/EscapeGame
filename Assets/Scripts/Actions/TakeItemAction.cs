using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Yuuta.EscapeGame
{
    public class TakeItemAction : YuutaAction
    {
        [SerializeField] private string _itemId;
        [SerializeField] private GameObject _itemGameObject;
        [SerializeField] private Backpack _backpack;

        private void Start()
        {
            if (_backpack.HasItem(_itemId) && _itemGameObject != null)
            {
                _itemGameObject.SetActive(false);
            }
        }

        public override void Do()
        {
            _backpack.GetItem(_itemId);
            if (_itemGameObject != null) 
                _itemGameObject.SetActive(false);
        }
    }
}