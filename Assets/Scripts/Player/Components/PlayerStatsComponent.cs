using Unity.Entities;

namespace Player.Components
{
    [GenerateAuthoringComponent]
    public struct PlayerStatsComponent : IComponentData
    {
        public float Health;
        public float Stamina;
    }
}