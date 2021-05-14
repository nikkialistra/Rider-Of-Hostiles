using Unity.Entities;

namespace UI.Systems
{
    [UpdateInGroup(typeof(GameObjectConversionGroup))]
    public class UiManagerConversionSystem : GameObjectConversionSystem
    {
        protected override void OnUpdate()
        {
            Entities
                .ForEach((UiManager uiManager) =>
                {
                    AddHybridComponent(uiManager);
                });
        }
    }
}