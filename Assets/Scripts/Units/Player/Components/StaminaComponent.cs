using Unity.Entities;

namespace Units.Player.Components
{
    [GenerateAuthoringComponent]
    public struct StaminaComponent : IComponentData
    {
        public float Value;

        public float DecreasingSpeed;
        public float IncreasingSpeed;
    }
}