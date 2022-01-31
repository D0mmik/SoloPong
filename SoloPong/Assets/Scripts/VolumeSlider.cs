using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{   
  public Slider volumeSlider;   

  void Start()
  {
    volumeSlider.value = PlayerPrefs.GetFloat("musicVolume", 1);
  }

  public void Volume()
  {
    AudioListener.volume = volumeSlider.value;
    PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
  }
  

  
}

