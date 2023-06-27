using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Player
{
   public class PlayerInputGrab : MonoBehaviour
   {
      private ButtonInput _buttonInput;
      private Vector2 _direction;
      private PlayerActions _playerActions;
      public Vector2 Direction => _direction;

      public void OnInit(PlayerActions playerActions)
      {
         _playerActions = playerActions;
         _buttonInput = new ButtonInput();
      }

      public void Enable()
      {
         _buttonInput.Enable();
         _buttonInput.Player.Move.performed += OnMove;
         _buttonInput.Player.Move.canceled += OnMoveCanceled;
         _buttonInput.Player.Action.performed += _playerActions.OnAction;
      }

      public void Disable()
      {
         _buttonInput.Disable();
         _buttonInput.Player.Move.performed -= OnMove;
         _buttonInput.Player.Move.canceled -= OnMoveCanceled;
         _buttonInput.Player.Action.performed -= _playerActions.OnAction;
      }

      private void OnMove(InputAction.CallbackContext value)
      {
         _direction = value.ReadValue<Vector2>();
      }

      private void OnMoveCanceled(InputAction.CallbackContext value)
      {
         _direction = Vector2.zero;
      }
   }
}
