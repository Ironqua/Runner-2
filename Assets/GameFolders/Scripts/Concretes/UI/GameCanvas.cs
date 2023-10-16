using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvas : MonoBehaviour
{
    [SerializeField] GameOverPanel _gamePanel;

    private void Awake()
    {
        _gamePanel.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        GameManager.Instance.OnGameStop += Instance_OnGameStop;
    }

    private void Instance_OnGameStop()
    {
        _gamePanel.gameObject.SetActive(true);
    }

    private void OnDisable()
    {
        GameManager.Instance.OnGameStop -= Instance_OnGameStop;
    }
}
