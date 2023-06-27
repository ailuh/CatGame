using UnityEngine;
using UnityEngine.Serialization;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Data", menuName = "PlayerData")]
    public class PlayerData : ScriptableObject
    {
        [SerializeField]
        private float movementSpeed;
        public float MovementSpeed => movementSpeed;
    }
}   
