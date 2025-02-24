using UnityEngine;

[RequireComponent(typeof(InputController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;

    InputController controller;
    Rigidbody rb;

    private void Awake()
    {
        controller = GetComponent<InputController>();
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3 (controller.MoveDir.x * speed, rb.linearVelocity.y, controller.MoveDir.y * speed);
    }
}
