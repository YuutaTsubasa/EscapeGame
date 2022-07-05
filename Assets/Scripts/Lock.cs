using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Yuuta.EscapeGame
{
    public class Lock : Condition
    {
        [SerializeField] private GameObject[] _items;
        [SerializeField] private int _answerIndex = 0;
        [SerializeField] private Button _upButton;
        [SerializeField] private Button _downButton;

        private int _currentIndex = 0;

        public event Action OnChange;
        
        void Start()
        {
            _ShowItems();
            
            _upButton.onClick.AddListener(_ChangePreviousItem);
            _downButton.onClick.AddListener(_ChangeNextItem);
        }

        private void OnDestroy()
        {
            Disable();
        }

        private void _ShowItems()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                _items[i].SetActive(i == _currentIndex);
            }
        }

        private void _ChangePreviousItem()
        {
            _currentIndex = ((_currentIndex - 1) + _items.Length) % _items.Length;
            _ShowItems();
            OnChange?.Invoke();
        }
        
        private void _ChangeNextItem()
        {
            _currentIndex = (_currentIndex + 1) % _items.Length;
            _ShowItems();
            OnChange?.Invoke();
        }

        public override bool Satisfy()
            => _currentIndex == _answerIndex;

        public void Disable()
        {
            _upButton.onClick.RemoveListener(_ChangePreviousItem);
            _downButton.onClick.RemoveListener(_ChangeNextItem);
        }
    }
}