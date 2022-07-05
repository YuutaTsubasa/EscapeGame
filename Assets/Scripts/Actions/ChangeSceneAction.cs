using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Yuuta.EscapeGame
{
    public class ChangeSceneAction : YuutaAction
    {
        [SerializeField] private GameObject _currentSceneGameObject;
        [SerializeField] private GameObject _nextSceneGameObject;

        public override void Do()
        {
            _currentSceneGameObject.SetActive(false);
            _nextSceneGameObject.SetActive(true);
        }
    }
}