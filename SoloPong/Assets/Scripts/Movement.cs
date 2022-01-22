using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    public Rigidbody player;
    public float Speed = 1500f;
    private float horizontal;
    public bool slowed = false;
    public bool useable = true;
    public GameObject clock;
    public AudioSource music; 
    // Start is called before the first frame update
    void Start()
    {
      clock.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      horizontal = Input.GetAxisRaw("Horizontal");

      player.velocity = new Vector3(horizontal, 0, 0) * Speed * Time.deltaTime;  
      
      
      if(Input.GetKey(KeyCode.Space) && slowed == false && useable == true)
      { slowed = true;
        Time.timeScale = 0.05f;
        Speed = 250000f;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
        useable = false;
        StartCoroutine(wait5());
        
      }

      if(useable == true)
      {
        clock.SetActive(true);
      }
      else
      {
        clock.SetActive(false);
      }
      
      if(slowed == true)
      {
        music.pitch = 0.8f;
      }
      else
      {
        music.pitch = 1f;
      }

    
    }
     IEnumerator wait5()
      {
        yield return new WaitForSeconds(0.1f);
        Time.timeScale = 1f;
        Speed = 1500f;
        slowed = false;
        StartCoroutine(nextuse());

        
      }
      IEnumerator nextuse()
      {
        yield return new WaitForSeconds(5f);
        useable = true;

      } 
}
