using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    GameObject[] startGameComponents;
    GameObject[] gameOverUIComponents;
    [SerializeField] GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        startGameComponents = GameObject.FindGameObjectsWithTag("start game");
       gameOverUIComponents = GameObject.FindGameObjectsWithTag("game over");
    DisableUIComponents (gameOverUIComponents);
        EnableUIComponents(startGameComponents);
        DisableScore(score);
    }
    public void DisableStartUI()
    {
        DisableUIComponents(startGameComponents);
    }

    public void GameOver()
    {
        EnableUIComponents(gameOverUIComponents);
        Time.timeScale = 0;
    }
    
    public void ShowScore()
    {
        score.SetActive(true);
    }

    private void EnableScore(GameObject score)
    {
        score.SetActive(true);
    }

    private void DisableScore(GameObject score)
    {
        score.SetActive(false);
    }

    private void EnableUIComponents(GameObject[] startGameComponents)
    {
        foreach(GameObject obj in startGameComponents)
        {
            obj.SetActive(true);
        }
    }

    private void DisableUIComponents(GameObject[] gameOverUIComponents)
    {
        foreach (GameObject obj in gameOverUIComponents)
        {
            obj.SetActive(false);
        }

        // Update is called once per frame
       
}
}
