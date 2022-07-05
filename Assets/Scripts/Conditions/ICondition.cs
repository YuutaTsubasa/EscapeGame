using UnityEngine;

namespace Yuuta.EscapeGame
{
    public interface ICondition
    {
        bool Satisfy();
    }

    public abstract class Condition : MonoBehaviour, ICondition
    {
        public abstract bool Satisfy();
    }
}