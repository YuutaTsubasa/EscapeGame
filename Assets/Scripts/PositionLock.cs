using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Yuuta.EscapeGame
{
    public class PositionLock : MonoBehaviour
    {
        [SerializeField] private Lock[] _locks;
        [SerializeField] private Room _room;
        [SerializeField] private string _itemId;
        [SerializeField] private string _getItemHint;

        private void Start()
        {
            if (_room.HasItem(_itemId))
                return;

            foreach (var @lock in _locks)
            {
                @lock.OnChange += _GetItem;
            }
            _GetItem();
        }

        private void _GetItem()
        {
            if (_room.HasItem(_itemId))
                return;
            
            if (_locks.Any(@lock => !@lock.IsCorrect()))
                return;
            
            
            _room.GetItem(_itemId);
            Dialog.Open(_getItemHint);
            
            foreach (var @lock in _locks)
            {
                @lock.Disable();
                @lock.OnChange -= _GetItem;
            }
        }

        private void OnDestroy()
        {
            foreach (var @lock in _locks)
            {
                @lock.OnChange -= _GetItem;
            }
        }
    }
}