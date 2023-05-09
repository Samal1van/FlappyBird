using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelManager : MonoBehaviour
{
    [SerializeField] private GameObject _startPanel;
    private void Start()
    {
        Time.timeScale = 0;
    }
    
    public void StartGame()
    {
        _startPanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
