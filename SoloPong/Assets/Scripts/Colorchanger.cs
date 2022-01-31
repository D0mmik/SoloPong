using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorchanger : MonoBehaviour
{  
    public Material green;

    void OnTriggerEnter(Collider other)
    {  
        if(other.CompareTag("hrac"))
        {
            
            this.gameObject.GetComponent<MeshRenderer>().material = green;
            
        }
    }
}
