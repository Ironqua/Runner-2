using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
 //   [SerializeField] EnemyController _enemyPrefab;
    [SerializeField] float _max;
    [SerializeField] float _min;
    
    [SerializeField ]float _maxSpawnTime;
    float _currentSpawnTime = 0f;
    private void OnEnable()
    {
        _maxSpawnTime=Random.Range(_min, _max);
    }

    private void Update()
    {
        _currentSpawnTime += Time.deltaTime;

        if(_currentSpawnTime > _maxSpawnTime)
        {
           
            Spawn();
        }
    }

    void Spawn()
    {
        EnemyController newEnemy = EnemyManager.Instance.GetPool();
        newEnemy.transform.parent = this.transform;
        newEnemy.transform.position = this.transform.position;
        newEnemy.gameObject.SetActive(true);
        _currentSpawnTime = 0f;
         
    }

}
