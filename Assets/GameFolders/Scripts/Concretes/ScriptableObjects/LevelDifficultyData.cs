using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Level Diffculty ",menuName ="Create Diffculty/Create New",order =1)]
public class LevelDifficultyData : ScriptableObject
{
    [SerializeField] FloorController _floorPrefab;
    [SerializeField] GameObject _spawnerPrefab;
    [SerializeField] Material _skyboxMaterial;


    public FloorController FloorPrefab => _floorPrefab;
    public GameObject SpawnerPrefab => _spawnerPrefab;
    public Material skyboxMaterial => _skyboxMaterial;

}
