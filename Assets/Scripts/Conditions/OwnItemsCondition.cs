using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Yuuta.EscapeGame
{
    public class OwnItemsCondition : Condition
    {
        [SerializeField] private string[] _shouldOwnedItemIds;
        [SerializeField] private Backpack _backpack;

        public override bool Satisfy()
            => _shouldOwnedItemIds.All(_backpack.HasItem);
    }
}