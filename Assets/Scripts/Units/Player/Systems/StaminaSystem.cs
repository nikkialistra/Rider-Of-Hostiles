using Units.Player.Components;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Physics.Systems;

namespace Units.Player.Systems
{
    [UpdateInGroup(typeof(FixedStepSimulationSystemGroup))]
    [UpdateAfter(typeof(EndFramePhysicsSystem))]
    public class StaminaSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            var fixedDeltaTime = Time.fixedDeltaTime;

            Entities
                .ForEach((ref StaminaComponent stamina, in PhysicsVelocity velocity) =>
                {
                    var speed = math.lengthsq(velocity.Linear) > math.EPSILON ? 
                        stamina.DecreasingSpeed : stamina.IncreasingSpeed;

                    var value = stamina.Value;

                    value += speed * fixedDeltaTime;
                    value = math.clamp(value, 0, 1);
                    
                    stamina.Value = value;
                }).Schedule();
        }
    }
}