using Unity.Entities;
using UnityEngine;

namespace Core.Controls
{
    [GenerateAuthoringComponent]
    public struct InputComponent : IComponentData
    {
        public Vector2 Move;
    }
}