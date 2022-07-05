using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yuuta.EscapeGame {
    public class Room : MonoBehaviour
    {
        [SerializeField] private GameObject _firstScene;
        [SerializeField] private GameObject _winGameObject;

        void Start()
        {
            _firstScene.SetActive(true);
        }
        
        public void Win()
        {
            _winGameObject.SetActive(true);
        }
    }
}