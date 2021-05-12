#nullable disable

using UnityEngine;
using UnityEngine.UIElements;

namespace Core.UI
{
    [RequireComponent(typeof(UIDocument))]
    public class UiManager : MonoBehaviour
    {
        private VisualElement _root;

        private GameView _gameView;

        private void Awake()
        {
            _root = GetComponent<UIDocument>().rootVisualElement;
        }

        private void Start()
        {
            _gameView = new GameView(_root);
        }
    }
}