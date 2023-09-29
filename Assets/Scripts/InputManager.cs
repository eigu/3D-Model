using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerControl playerControl;
    public Vector2 movementInput;
    public float verticalInput;
    public float horizontalInput;

    public void OnEnable()
    {
        if (playerControl ==  null)
        {
            playerControl = new PlayerControl();
            playerControl.PlayerInput.WASD.performed += i => movementInput = i.ReadValue<Vector2>();
        }

        playerControl.Enable();
    }

    private void OnDisable()
    {
        playerControl.Disable();
    }

    public void HandlesAllInput()
    {
        HandleMovementInput();
    }

    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
    }
}
