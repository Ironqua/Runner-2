using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInitalizerControlller : MonoBehaviour
{
    LevelDifficultyData _levelDifficultyData;

    private void Awake()
    {
        _levelDifficultyData = GameManager.Instance.LevelDifficultyData;

    }

    private void Start()
    {
        RenderSettings.skybox = _levelDifficultyData.skyboxMaterial;
        Instantiate(_levelDifficultyData.FloorPrefab);
        Instantiate(_levelDifficultyData.SpawnerPrefab);

    }
}
