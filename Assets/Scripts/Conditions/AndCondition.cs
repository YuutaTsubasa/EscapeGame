using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Yuuta.EscapeGame
{
    public class AndCondition : Condition
    {
        [SerializeField] private Condition[] _conditions;

        public override bool Satisfy()
            => _conditions.All(condition => condition.Satisfy());
    }
}