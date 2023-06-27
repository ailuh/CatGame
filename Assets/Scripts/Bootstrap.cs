using Player;
using ScriptableObjects;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] 
    private PlayerInputGrab playerInputGrab;
    [SerializeField] 
    private PlayerMovement playerMovement;
    [SerializeField] 
    private PlayerActions playerActions;
    [SerializeField] 
    private PlayerData playerData;


    private void Awake()
    {
        playerActions.OnInit();
        playerMovement.OnInit(playerInputGrab, playerData.MovementSpeed);
        playerInputGrab.OnInit(playerActions);
    }
    
    private void OnEnable()
    {
        playerInputGrab.Enable();
    }
    
    private void OnDisable()
    {
        playerInputGrab.Disable();
    }
}
