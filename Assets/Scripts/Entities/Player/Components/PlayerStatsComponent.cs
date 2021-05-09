using Unity.Entities;

namespace Entities.Player.Components
{
    [GenerateAuthoringComponent]
    public struct PlayerStatsComponent : IComponentData
    {
        public float Health;
        public float Stamina;
    }
}