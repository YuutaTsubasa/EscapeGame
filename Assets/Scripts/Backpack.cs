using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yuuta.EscapeGame
{
    public class Backpack : MonoBehaviour
    {
        private HashSet<string> _ownItems = new HashSet<string>();
        
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