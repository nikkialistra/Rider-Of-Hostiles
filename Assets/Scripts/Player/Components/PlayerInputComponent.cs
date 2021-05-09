using Unity.Entities;
using UnityEngine;

namespace Player.Components
{
    [GenerateAuthoringComponent]
    public struct PlayerInputComponent : IComponentData
    {
        public Vector2 Move;
    }
}