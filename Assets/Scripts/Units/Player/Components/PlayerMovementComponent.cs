using Unity.Entities;

namespace Units.Player.Components
{
    [GenerateAuthoringComponent]
    public struct PlayerMovementComponent : IComponentData
    {
        public float Force;
    }
}