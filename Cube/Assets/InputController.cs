using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    PlayerInput action;
    PlayerInput.PlayerActions playerAction;

    public Vector2 MoveDir { get; set; }


    private void Awake()
    {
        action = new PlayerInput();
        playerAction = action.Player;
        playerAction.Move.performed += ctx => GetMoveDir();
    }

    private void GetMoveDir()
    {
        MoveDir = playerAction.Move.ReadValue<Vector2>();
    }

    private void OnEnable()
    {
        action.Enable();
    }
    private void OnDisable()
    {
        action.Disable();
    }
}
