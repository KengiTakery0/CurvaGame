using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] InputController controller;

    private void Update()
    {
        Debug.Log(Camera.main.ScreenToWorldPoint(controller.MousePos));
    }
}
