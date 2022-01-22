using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{  
    public GameObject ball;
    public GameObject Enemy;
    private GameObject Clone;
    private GameObject spawnthis;

    private float number;
    public bool canSpawn = true;

    private float minX = 8.5f;
    private float maxX = -8.5f;
    private float minY = 7f;
    private float maxY = 8f;
    public double Timer = 0.3;
    private Vector3 randomPosition;
    
   
    void Update()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX),Random.Range(minY, maxY), 0);
        
        number = Random.Range(0f,2f);
        if(number <= 1)
        {
          spawnthis = ball;
        }
        else if(number >= 1)
        {
          spawnthis = Enemy;
        }

        Timer -= Time.deltaTime;
        if (Timer <= 0f && canSpawn == true)
        {
          Clone = Instantiate(spawnthis,randomPosition,Quaternion.identity) as GameObject;
          Destroy(Clone,3);
          Timer = 0.3f;
        }
      
	}  

}
