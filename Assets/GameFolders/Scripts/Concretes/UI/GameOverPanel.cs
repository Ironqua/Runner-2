using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
  
    public void RestartBUtton()
    {
        GameManager.Instance.NextScene("MainScene");

    }

    public void Qu�tButton()
    {
       GameManager.Instance.AppExit();
    }


}
