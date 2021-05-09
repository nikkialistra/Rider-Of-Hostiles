using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace Units.Player
{
    public class EntityFollower : MonoBehaviour
    {
        public Entity EntityToFollow;

        private EntityManager _entityManager;

        private void Awake()
        {
            _entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        }

        private void LateUpdate()
        {
            if (EntityToFollow == Entity.Null)
            {
                return;
            }

            var translation = _entityManager.GetComponentData<Translation>(EntityToFollow);
            transform.position = translation.Value;
        }
    }
}