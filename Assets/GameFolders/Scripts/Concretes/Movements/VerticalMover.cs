using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMover 
{
   //float _enemyMoveSpeed = 1f;
    EnemyController _enemyController;
    public VerticalMover(EnemyController enemyController)
    {
        _enemyController = enemyController;
    }
    public void FixedTick(float vertical = 1, float _enemyMoveSpeed = 10f)
    {
        _enemyController.transform.Translate(Vector3.back*vertical*Time.deltaTime*_enemyMoveSpeed);
        
    }
}
