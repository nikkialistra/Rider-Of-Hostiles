using UnityEngine;
using UnityEngine.UIElements;

namespace Core.UI
{
    public class GameView
    {
        public float Stamina
        {
            get => _stamina.value;
            set => _stamina.value = value;
        }

        private VisualElement _root;
        
        private Slider _health;
        private Slider _stamina;
        private Slider _hunger;
        private Slider _thirst;
        private Slider _immunity;
        private Slider _temperature;
        private Slider _psyche;

        public GameView(VisualElement root)
        {
            _root = root;
            
            var template = Resources.Load<VisualTreeAsset>("UI/GameView");
            _root.Add(template.CloneTree());

            _health = _root.Q<Slider>("health");
            _stamina = _root.Q<Slider>("stamina");
            _hunger = _root.Q<Slider>("hunger");
            _thirst = _root.Q<Slider>("thirst");
            _immunity = _root.Q<Slider>("immunity");
            _temperature = _root.Q<Slider>("temperature");
            _psyche = _root.Q<Slider>("psyche");
        }
    }
}