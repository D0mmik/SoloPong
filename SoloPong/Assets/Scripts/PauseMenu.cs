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
        Cursor.visible = false;

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
                Cursor.visible = true;  
            }
        }

        if(Input.GetKey(KeyCode.R))
        {
          SceneManager.LoadScene("Game");
          Time.timeScale = 1f;
          
        }

        if(isPaused)
            {
                Cursor.visible = true;              
            }
            else
            {
                Cursor.visible = false;
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
        SceneManager.LoadScene("Menu");
        
    }
    public void ResetButton()
    {
      PlayerPrefs.SetInt("Highscore", 0);
    }
}
