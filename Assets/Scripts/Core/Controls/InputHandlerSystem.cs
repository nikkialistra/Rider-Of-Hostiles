using Unity.Entities;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Core.Controls
{
    public class InputHandlerSystem : SystemBase
    {
        private Control? _control;
        private Control.PlayerActions _playerActions;
        
        protected override void OnCreate()
        {
            _control = new Control();
            _control.Enable();
            
            _playerActions = _control.Player;
        }

        protected override void OnUpdate()
        {
            InputSystem.Update();

            var move = _playerActions.Move.ReadValue<Vector2>();
            
            Entities
                .ForEach((ref InputComponent input) =>
                {
                    input.Move = move;
                }).Run();
        }
    }
}