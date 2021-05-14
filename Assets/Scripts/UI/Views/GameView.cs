using UnityEngine.UIElements;

namespace UI.Views
{
    public class GameView
    {
        public float Stamina
        {
            get => _stamina.value;
            set => _stamina.value = value;
        }
        
        private Slider _health;
        private Slider _stamina;
        private Slider _hunger;
        private Slider _thirst;
        private Slider _immunity;
        private Slider _temperature;
        private Slider _psyche;

        public GameView(VisualElement root)
        {
            _health = root.Q<Slider>("health");
            _stamina = root.Q<Slider>("stamina");
            _hunger = root.Q<Slider>("hunger");
            _thirst = root.Q<Slider>("thirst");
            _immunity = root.Q<Slider>("immunity");
            _temperature = root.Q<Slider>("temperature");
            _psyche = root.Q<Slider>("psyche");
        }
    }
}