using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Yuuta.EscapeGame
{
    public class Dialog : MonoBehaviour
    {
        [SerializeField] private Button _backgroundButton;
        [SerializeField] private Text _text;

        public static void Open(string content)
        {
            var dialog = Instantiate( Resources.Load<Dialog>("Dialog"));
            dialog.Show(content);
        }

        public void Show(string content)
        {
            _text.text = content;
            _backgroundButton.onClick.AddListener(_Close);
        }

        private void _Close()
        {
            _backgroundButton.onClick.RemoveListener(_Close);
            Destroy(gameObject);
        }
    }
}