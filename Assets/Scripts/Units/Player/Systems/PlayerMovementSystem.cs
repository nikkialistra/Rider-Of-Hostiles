using Core.Controls;
using Units.Player.Components;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Physics.Extensions;
using Unity.Physics.Systems;

namespace Units.Player.Systems
{
    [UpdateInGroup(typeof(FixedStepSimulationSystemGroup))]
    [UpdateAfter(typeof(EndFramePhysicsSystem))]
    public class PlayerMovementSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            var deltaTime = Time.DeltaTime;
            
            Entities
                .ForEach((ref PhysicsVelocity velocity, ref PhysicsMass mass, in PlayerMovementComponent movement, in InputComponent input) =>
                {
                    var move = input.Move;
                    
                    var direction = new float3(move.x, 0, move.y);
                    velocity.ApplyLinearImpulse(mass, direction * movement.Force * deltaTime);
                })
                .Schedule();
        }
    }
}