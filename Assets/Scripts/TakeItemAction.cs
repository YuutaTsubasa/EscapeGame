using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Yuuta.EscapeGame
{
    public class TakeItemAction : MonoBehaviour
    {
        [SerializeField] private string _itemId;
        [SerializeField] private Button _button;
        [SerializeField] private GameObject _itemGameObject;
        [SerializeField] private Room _room;

        private void Start()
        {
            if (_room.HasItem(_itemId))
            {
                _itemGameObject.SetActive(false);
                return;
            }

            _button.onClick.AddListener(_GetItem);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(_GetItem);
        }

        private void _GetItem()
        {
            _room.GetItem(_itemId);
            _itemGameObject.SetActive(false);
        }
    }
}