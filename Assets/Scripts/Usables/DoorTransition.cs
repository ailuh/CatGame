using UnityEngine;

namespace Usables
{
    public class DoorTransition : MonoBehaviour
    {
        private PlayerActions _playerActions;
        private void OnTriggerEnter2D(Collider2D other)
        {
            other.TryGetComponent(out _playerActions);
            if (_playerActions != null) 
                _playerActions.OnDoor();
        }
    
        private void OnTriggerExit2D(Collider2D other)
        {
            if (_playerActions) 
                _playerActions.OnDoorExit();
            _playerActions = null;
        }
    }
}
