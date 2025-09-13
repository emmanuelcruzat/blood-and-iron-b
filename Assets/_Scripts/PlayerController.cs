using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 moveInput;

    void Update()
    {
        // move based on current input
        Vector3 move = new Vector3(moveInput.x, moveInput.y, 0f);
        transform.position += move * speed * Time.deltaTime;
    }

    // This will be hooked to the "Move" action in PlayerInput (Events mode)
    public void HandleMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}