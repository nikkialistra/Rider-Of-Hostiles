using Unity.Entities;

namespace Player.Components
{
    [GenerateAuthoringComponent]
    public struct PlayerMovementComponent : IComponentData
    {
        public float Force;
    }
}