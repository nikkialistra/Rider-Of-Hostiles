using Units.Player.Components;
using Unity.Entities;
using UnityEngine;

namespace UI.Systems
{
    public class IndicatorsUiSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            float staminaValue = 0;

            Entities
                .ForEach((in StaminaComponent stamina) =>
                {
                    staminaValue = Mathf.Round(stamina.Value * 100);
                }).Run();
            
            Entities
                .WithoutBurst()
                .ForEach((UiManager uiManager) =>
                {
                    uiManager.GameView.Stamina = staminaValue;
                }).Run();
        }
    }
}