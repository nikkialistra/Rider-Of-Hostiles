using Unity.Entities;

namespace Entities.Player.Components
{
    [GenerateAuthoringComponent]
    public struct PlayerMovementComponent : IComponentData
    {
        public float Force;
    }
}