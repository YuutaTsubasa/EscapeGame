using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Yuuta.EscapeGame
{
    public class WinAction : MonoBehaviour
    {
        [SerializeField] private string[] _ownItemsCondition;
        [SerializeField] private string _unachieveConditionHint;
        [SerializeField] private Button _button;
        [SerializeField] private Room _room;
        [SerializeField] private GameObject _currentSceneGameObject;
        [SerializeField] private GameObject _nextSceneGameObject;

        private void Start()
        {
            _button.onClick.AddListener(_Win);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(_Win);
        }

        private void _Win()
        {
            if (_ownItemsCondition.All(_room.HasItem))
            {
                _room.Win();
                _currentSceneGameObject.SetActive(false);
                _nextSceneGameObject.SetActive(true);
            }
            else
            {
                Dialog.Open(_unachieveConditionHint);
            }
        }
    }
}