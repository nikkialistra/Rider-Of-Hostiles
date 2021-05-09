using Player.Components;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Physics.Extensions;

namespace Player.Systems
{
    [UpdateInGroup(typeof(FixedStepSimulationSystemGroup))]
    public class PlayerMovementSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            var deltaTime = Time.DeltaTime;

            Entities
                .ForEach((ref PhysicsVelocity velocity, ref PhysicsMass mass, in PlayerMovementComponent movement, in PlayerInputComponent input) =>
                {
                    var move = input.Move;
                    
                    var direction = new float3(move.x, 0, move.y); 
                    PhysicsComponentExtensions.ApplyLinearImpulse(ref velocity, mass, direction * movement.Force * deltaTime);
                })
                .Schedule();
        }
    }
}