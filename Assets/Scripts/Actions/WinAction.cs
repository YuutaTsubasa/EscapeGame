using UnityEngine;

namespace Yuuta.EscapeGame
{
    public class WinAction : YuutaAction
    {
        [SerializeField] private Room _room;
        
        public override void Do()
        {
            _room.Win();
        }
    }
}