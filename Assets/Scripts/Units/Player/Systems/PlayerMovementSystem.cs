using Core.Controls;
using Units.Player.Components;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Physics.Extensions;
using Unity.Physics.Systems;
using UnityEngine;

namespace Units.Player.Systems
{
    [UpdateInGroup(typeof(FixedStepSimulationSystemGroup))]
    [UpdateAfter(typeof(EndFramePhysicsSystem))]
    public class PlayerMovementSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            var fixedDeltaTime = Time.fixedDeltaTime;
            
            Entities
                .ForEach((ref PhysicsVelocity velocity, ref PhysicsMass mass, in PlayerMovementComponent movement,
                    in InputComponent input, in StaminaComponent stamina) =>
                {
                    var move = input.Move;
                    if (move == Vector2.zero)
                    {
                        velocity.Linear = 0;
                        velocity.Angular = 0;
                        return;
                    }

                    var direction = new float3(move.x, 0, move.y);

                    var forceMultiplier = stamina.Value > math.EPSILON ? 
                        1f : 0.1f;
                    
                    velocity.ApplyLinearImpulse(mass, direction * movement.Force * forceMultiplier * fixedDeltaTime);

                    })
                .Schedule();
        }
    }
}