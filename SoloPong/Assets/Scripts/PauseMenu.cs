using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{   public static bool isPaused = false;
    public GameObject Menu;
    public AudioSource music;

    void Start()
    {
        isPaused = false;
        Menu.SetActive(false);

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        if(Input.GetKey(KeyCode.R))
        {
          SceneManager.LoadScene("Game");
          Time.timeScale = 1f;
          
        }
    }
    public void Resume()
    {
      Menu.SetActive(false);
      Time.timeScale = 1f;
      isPaused = false; 
      music.UnPause();
    }
    void Pause()
    {
      Menu.SetActive(true);
      Time.timeScale = 0f;
      isPaused = true;
      music.Pause(); 
    }
    public void MenuButton()
    {
        SceneManager.LoadScene(0);
        
    }
    public void RestartButton()
    {
     
    }
}
