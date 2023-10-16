using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader :IInputReader
{

    
    PlayerInput _playerInput;
    public float Horizontal { get; private set; }
    public bool isJump { get; private set; }
    public InputReader(PlayerInput playerInput)
    {
       _playerInput = playerInput;
        _playerInput.currentActionMap.actions[0].performed += OnHorizontalMove;
        _playerInput.currentActionMap.actions[1].started += OnJumpping;
        _playerInput.currentActionMap.actions[1].canceled += OnJumpping;
    }

    private void OnJumpping(InputAction.CallbackContext obj)
    {
      isJump=obj.ReadValueAsButton();
    }

    private void OnHorizontalMove(InputAction.CallbackContext context)
    {
    Horizontal=context.ReadValue<float>();
    }
}
