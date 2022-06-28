using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Yuuta.EscapeGame
{
    public class ChangeSceneAction : MonoBehaviour
    {
        [SerializeField] private string[] _ownItemsCondition;
        [SerializeField] private string _unachieveConditionHint;
        [SerializeField] private Room _room;

        [SerializeField] private Button _button;
        [SerializeField] private GameObject _currentSceneGameObject;
        [SerializeField] private GameObject _nextSceneGameObject;

        private void Start()
        {
            _button.onClick.AddListener(_ChangeScene);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(_ChangeScene);
        }

        private void _ChangeScene()
        {
            if (_ownItemsCondition.Length == 0 ||
                _ownItemsCondition.All(_room.HasItem))
            {
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