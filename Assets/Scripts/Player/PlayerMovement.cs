using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private float _speed;
        private PlayerInputGrab _playerInput;
        private Rigidbody2D _rb;
        public void OnInit(PlayerInputGrab playerInput, float speed)
        {
            _rb = GetComponent<Rigidbody2D>();
            _speed = speed;
            _playerInput = playerInput;
        }
    
        private void FixedUpdate()
        {
            Move();
        }

        private void Move()
        {
            var movement = _playerInput.Direction * _speed;
            var newPosition =  _rb.position + movement * Time.fixedDeltaTime;
            _rb.MovePosition(newPosition);
        }
        
    }
}
