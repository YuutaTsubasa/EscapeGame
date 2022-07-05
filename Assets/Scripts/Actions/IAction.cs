using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Yuuta.EscapeGame
{
    public interface IYuutaAction
    {
        void Do();
    }

    public abstract class YuutaAction : MonoBehaviour, IYuutaAction
    {
        public abstract void Do();
    }
}