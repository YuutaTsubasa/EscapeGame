using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Yuuta.EscapeGame
{
    public class ButtonClickTrigger : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private Condition _condition;
        [SerializeField] private YuutaAction[] _satisfiedConditionActions;
        [SerializeField] private YuutaAction[] _unsatisfiedConditionActions;

        private void Start()
        {
            _button.onClick.AddListener(_Trigger);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(_Trigger);
        }

        private void _Trigger()
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