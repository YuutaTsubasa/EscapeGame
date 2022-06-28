using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yuuta.EscapeGame {
    public class Room : MonoBehaviour
    {
        [SerializeField] private GameObject _firstScene;
        [SerializeField] private GameObject _winGameObject;

        private HashSet<string> _ownItems = new HashSet<string>();

        void Start()
        {
            _firstScene.SetActive(true);
        }
        
        public void Win()
        {
            _winGameObject.SetActive(true);
        }
        
        public void GetItem(string itemId)
        {
            _ownItems.Add(itemId);
        }

        public void UseItem(string itemId)
        {
            _ownItems.Remove(itemId);
        }

        public bool HasItem(string itemId)
            => _ownItems.Contains(itemId);
    }
}