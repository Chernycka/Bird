using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    public void ReloadLevel()
    {
        //SceneManager.LoadScene("GameScene");
        SceneManager.LoadScene(0);
        ResumeGame();
    }
    public void LoadSettings()
    {
        //SceneManager.LoadScene("GameScene");
        SceneManager.LoadScene(2);
        ResumeGame();
    }
    public void LoadMainManu()
    {
        SceneManager.LoadScene(0);
        ResumeGame();
    }
    public void Exit() { Application.Quit();}
    private void ResumeGame() { Time.timeScale = 1; }

}
