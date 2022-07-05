using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yuuta.EscapeGame
{
    public class TriggerAction : YuutaAction
    {
        [SerializeField] private Condition _condition;
        [SerializeField] private YuutaAction[] _satisfiedConditionActions;
        [SerializeField] private YuutaAction[] _unsatisfiedConditionActions;
        
        public override void Do()
        {
            if (_condition == null || _condition.Satisfy())
            {
                foreach (var satisfiedConditionAction in _satisfiedConditionActions)
                {
                    satisfiedConditionAction.Do();
                }
            }
            else
            {
                foreach (var unsatisfiedConditionAction in _unsatisfiedConditionActions)
                {
                    unsatisfiedConditionAction.Do();
                }
            }
        }
    }
}