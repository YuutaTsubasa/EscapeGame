using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yuuta.EscapeGame
{
    public class DialogAction : YuutaAction
    {
        [SerializeField] private string _content;

        public override void Do()
        {
            Dialog.Open(_content);
        }
    }
}