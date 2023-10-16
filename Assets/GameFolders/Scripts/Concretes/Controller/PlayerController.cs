using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] float _movespeed;
    [SerializeField] float _jumpForce;
    [SerializeField] bool _isJumping;
    PlayerMovement _playerMovement;
    PlayerJumpMechanic _playerJumpMechanic;

    IInputReader _input;
    float _horizontal;
    bool _isJump;
   

    private void Awake()
    {
      _playerMovement = new PlayerMovement(this); 
        _playerJumpMechanic = new PlayerJumpMechanic(this);
        _input=new InputReader(GetComponent<PlayerInput>());

    }

    private void Update()
    {
        _horizontal = _input.Horizontal;
        Debug.Log(_input.isJump);
        Debug.Log(_input.Horizontal);

        if(_input.isJump )
        {
            _isJumping = true;
        }

    }


    private void FixedUpdate()
    {
        _playerMovement.FixedTick(_horizontal, _movespeed);
        if(_isJumping )
        {
            _playerJumpMechanic.TickFixed(_jumpForce);
            _isJumping=false;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        EnemyController enemyController =collision.GetComponent<EnemyController>();
        if(enemyController != null)
        {
            GameManager.Instance.StopGame();
            
        }
    }
}
