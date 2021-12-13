using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GOPanel;
    public GameObject PausePanel;
    public GameObject PauseButton;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        GOPanel.SetActive(true);
        PauseButton.SetActive(false);
    }

    public void RestartGame() 
    {
        Destroy(GameObject.Find("BGM"));
        SceneManager.LoadScene("Cutscene");
        
    }

    public void PauseGame ()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
        PauseButton.SetActive(false);
    }

    public void ResumeGame ()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        PauseButton.SetActive(true);
    }

    public void Exit()
    {
        Destroy(GameObject.Find("BGM"));
        SceneManager.LoadScene("MainMenu");
        
    }
    
}
