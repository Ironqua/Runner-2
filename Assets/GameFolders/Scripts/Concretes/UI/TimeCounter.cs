using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    float _currentTime;
    Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        _text.text = _currentTime.ToString("0");
    }




}
