using Unity.Entities;

namespace Units.Player.Components
{
    [GenerateAuthoringComponent]
    public struct PlayerStatsComponent : IComponentData
    {
        public float Health;
        public float Stamina;
    }
}