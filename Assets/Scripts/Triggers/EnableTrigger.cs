using UnityEngine;

namespace Yuuta.EscapeGame
{
    public class EnableTrigger : MonoBehaviour
    {
        [SerializeField] private Condition _condition;
        [SerializeField] private YuutaAction[] _satisfiedConditionActions;
        [SerializeField] private YuutaAction[] _unsatisfiedConditionActions;

        private void OnEnable()
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