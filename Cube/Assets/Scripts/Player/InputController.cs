using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    PlayerInput action;
    PlayerInput.PlayerActions playerAction;

    public Vector2 MousePos { get; set; }
    float loopDir;

    private void Awake()
    {
        action = new PlayerInput();
        playerAction = action.Player;
        playerAction.MouseMove.performed += ctx => GetMoveDir();
        playerAction.Loop.performed += ctx => GetLoopDir();
    }

    private void GetMoveDir()
    {
        MousePos = playerAction.MouseMove.ReadValue<Vector2>();
        Debug.Log(MousePos);
    }
    private void GetLoopDir()
    {
        loopDir = playerAction.Loop.ReadValue<float>();
        Debug.Log(loopDir);
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
