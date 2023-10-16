using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpMechanic
{
    Rigidbody _playerRigidbody;
    public bool canJump { get; set; }
    public PlayerJumpMechanic(PlayerController playerController)
    {
        _playerRigidbody=playerController.GetComponent<Rigidbody>();
    }

    public void TickFixed(float jumpForce)
    {
        if (canJump)
        {
            _playerRigidbody.velocity = Vector3.zero;
            _playerRigidbody.AddForce(Vector3.up * Time.deltaTime * jumpForce);
            canJump = false;
        }
        else
        {
            canJump=_playerRigidbody.velocity.y==0f;
        }
    }
}
