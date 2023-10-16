using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement 
{
    PlayerController _playerController;
    PlayerJumpMechanic _playerJumpMechanic;
    Vector3 velocity;
    //bool isground;
    //[SerializeField]float jumpheight;
    //[SerializeField]float gravity;

   

    public PlayerMovement(PlayerController playerController)
    {
        _playerController = playerController;

    }

    public void FixedTick(float horizontal,float speed)
    {
        //#region try jump
        //if (Input.GetKeyDown(KeyCode.Space)&&isground)
        //{
        //    isground = true;
        //   velocity.y += Mathf.Sqrt(jumpheight * -3.0f * gravity);
        //}
        //#endregion


        if (horizontal == 0)
        {
            return;
        }

        _playerController.transform.Translate(Vector3.right*horizontal*Time.deltaTime*speed);
    }

}
