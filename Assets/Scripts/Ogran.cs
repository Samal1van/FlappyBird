using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogran : MonoBehaviour
{
    public GameObject gameOver;
    private Bird _bird;

    private void Awake()
    {
        _bird = GetComponent<Bird>();
    }

    void Update()
    {
        if (transform.position.y < -3.5f || transform.position.y > 4f)
        {
            _bird.GameOver();
        }
    }
}
