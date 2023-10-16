using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class UIManagers : MonoBehaviour
{
    public void DiffcultyChoose(int index)
    {
        GameManager.Instance.DiffcultyIndex = index;
        GameManager.Instance.NextScene("MainScene");

    }

    public void ExitButton()
    {
        GameManager.Instance.AppExit();
    }

    
}
