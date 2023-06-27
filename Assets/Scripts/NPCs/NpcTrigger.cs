using System;
using cherrydev;
using Dialogues;
using UnityEngine;
using UnityEngine.Serialization;

public class NpcTrigger : MonoBehaviour
{
    [SerializeField] 
    private Animator animator;
    [SerializeField] 
    private DialogueStarter dialogStarter;
    [SerializeField] 
    private GameObject dialogueWaiting;
    private PlayerActions _playerActions;

    private void Start()
    {
        animator.enabled = false;
        dialogueWaiting.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.TryGetComponent(out _playerActions);
        if (_playerActions != null)
        {
            _playerActions.OnDialogue(dialogStarter);
            dialogueWaiting.SetActive(true);
            animator.enabled = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (_playerActions)
        {
            _playerActions.OnDialogueExit();
            dialogueWaiting.SetActive(false);
            animator.enabled = false;
        }
        _playerActions = null;
    }
}
