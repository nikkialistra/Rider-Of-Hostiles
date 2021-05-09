using Unity.Entities;
using UnityEngine;

namespace Units.Player
{
    public class LeaderAuthoring : MonoBehaviour, IConvertGameObjectToEntity
    {
        [SerializeField] private EntityFollower? _entityFollower;
        
        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            if (_entityFollower == null)
            {
                return;
            }

            _entityFollower.EntityToFollow = entity;
        }
    }
}