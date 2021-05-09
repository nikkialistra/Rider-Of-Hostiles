using Player.Components;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Physics.Extensions;
using UnityEngine;

namespace Player.Systems
{
    [UpdateInGroup(typeof(FixedStepSimulationSystemGroup))]
    public class PlayerMovementSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            var deltaTime = Time.DeltaTime;

            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");

            Entities
                .WithAll<PlayerMovementComponent>()
                .ForEach((ref PhysicsVelocity velocity, ref PhysicsMass mass, in PlayerMovementComponent movement) =>
                {
                    var direction = new float3(horizontal, 0, vertical); 
                    PhysicsComponentExtensions.ApplyLinearImpulse(ref velocity, mass, direction * movement.Force);
                })
                .Schedule();
        }
    }
}