using Dialogues;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActions : MonoBehaviour
{
    private bool _isDoor;
    private bool _isDialogue;
    private DialogueStarter _currentDialogStarter;


    public void OnInit()
    {
        _isDoor = false;
    }
    public void OnDoor()
    {
        _isDoor = true;
        Debug.Log("OnDoor");
    }
    
    public void OnDoorExit()
    {
        _isDoor = false;
        Debug.Log("OnDoorExit");
    }
    
    public void OnDialogue(DialogueStarter dialogStarter)
    {
        _isDialogue = true;
        _currentDialogStarter = dialogStarter;
    }
    
    public void OnDialogueExit()
    {
        _isDialogue = false;
        _currentDialogStarter = null;
    }
    
    public void OnAction(InputAction.CallbackContext value)
    {
        EnterTheDoor();
    }

    private void EnterTheDoor()
    {
        if (_isDoor) 
            Debug.Log("EnterTheHouse");
        if (_isDialogue)
        {
            if (_currentDialogStarter != null)
            {
                _currentDialogStarter.StartDialog();
                _currentDialogStarter = null;
            }
        }
    }
}
