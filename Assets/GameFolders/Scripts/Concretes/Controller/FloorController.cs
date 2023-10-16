using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    Material _material;
    [SerializeField] float _floorSpeed;

    private void Awake()
    {
        _material = GetComponentInChildren<MeshRenderer>().material;
    }

    private void Update()
    {
        _material.mainTextureOffset += Vector2.down * Time.deltaTime * _floorSpeed;
    }

}
