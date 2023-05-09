using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using TMPro;

public class Bird : MonoBehaviour
{ 
    [SerializeField] private int _score;
    [SerializeField] private TMP_Text _scoreText; 
    [SerializeField] private GameObject _endPanel;
    private BirdMove _birdMove;

    private void Start()
    {
       _birdMove = GetComponent<BirdMove>();
    }

    protected void IncreaseScore()
     {
        _score++;
        _scoreText.text = "Score: " + _score;
     }
     public void GameOver()
     {
        Time.timeScale = 0;
        _endPanel.SetActive(true);
     }
     
}
