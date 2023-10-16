using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour,IEntityController
{
    VerticalMover _mover;
    //[SerializeField] float enemyMoveSpeed;
    float _movespeed;
    float _currentLifeTime = 0f;
   [SerializeField] float _maxLifeTime = 10f;
    void Awake()
    {
        _movespeed = Random.Range(12, 25);
        _mover = new VerticalMover(this);
    }

    void Update()
    {
        _currentLifeTime += Time.deltaTime;

        if (_currentLifeTime > _maxLifeTime)
        {
            _currentLifeTime = 0f;
            KillYourself();
        }
    }

    void FixedUpdate()
    {
        _mover.FixedTick(1,_movespeed);
    }

    void KillYourself()
    {
        EnemyManager.Instance.SetPool(this);
    }

}
