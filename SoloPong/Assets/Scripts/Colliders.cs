using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colliders : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
      if(other.CompareTag("Enemy"))
      {
        SceneManager.LoadScene("Game");
      }
    }
}
