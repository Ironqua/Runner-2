using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingletonDesignPattern<GameManager>

{
    [SerializeField] LevelDifficultyData[] _levelDifficultyDatas;

    public LevelDifficultyData LevelDifficultyData => _levelDifficultyDatas[DiffcultyIndex];

    int _levelDifficultyIndex;

    public int DiffcultyIndex

    {
        get => _levelDifficultyIndex;
        set
        {
            if (_levelDifficultyIndex < 0 || _levelDifficultyIndex > _levelDifficultyDatas.Length)
            {
                NextSceneAsync("MenuScene");

            }
            else
            {
                _levelDifficultyIndex = value;
            }
        }
    }
    public event System.Action OnGameStop;

    private void Awake()
    {
        SingletonThisObject(this);
    }

    public void StopGame()
    {
        Time.timeScale = 0;
        OnGameStop?.Invoke();
    }
    public void NextScene(string sceneName)
    {
  
     StartCoroutine(NextSceneAsync(sceneName));

    }


    IEnumerator NextSceneAsync(string sceneName)
    {
        Time.timeScale = 1f;
       yield return SceneManager.LoadSceneAsync(sceneName);  
    }




    public void AppExit()
    {
        Debug.Log("quýt;");

        Application.Quit();
    }

   

}
