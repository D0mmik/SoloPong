using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorecount : MonoBehaviour
{   public int score = 0;
    public Material Bluemat;
    public GameObject ballobject;
    public TMP_Text scoretext;
    public TMP_Text highscoretext;

    void Start()
    {
       highscoretext.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }


    void OnTriggerEnter(Collider other)
    {  
        if(other.CompareTag("Ball"))
        {
            score++;
            
            
        }
    }
    void Update()
    {
        scoretext.text = score.ToString();
        if(score >= PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score);
            highscoretext.text = score.ToString();
        }


        
    }
}
