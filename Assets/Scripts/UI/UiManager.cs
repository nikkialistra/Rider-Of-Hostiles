#nullable disable

using UI.Views;
using UnityEngine;
using UnityEngine.UIElements;

namespace UI
{
    public class UiManager : MonoBehaviour
    {
        public GameView GameView { get; private set; }

        private VisualElement _root;

        private void Awake()
        {
            _root = FindObjectOfType<UIDocument>().rootVisualElement;
        }

        private void Start()
        {
            GameView = new GameView(_root);
        }
    }
}