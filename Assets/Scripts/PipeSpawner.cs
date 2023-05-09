using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _pipe;
    
    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0.2f, 0.5f);
    }
    
    void Spawn()
    {
        Instantiate(_pipe, transform.position ,transform.rotation);
        transform.position = new Vector3(transform.position.x+3,Random.Range(-1f,1f),transform.position.z);
    }
}
