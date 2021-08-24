using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bbTriggerAction : MonoBehaviour
{

    void OnTriggerEnter(Collider other) 
    {
        Debug.Log ("Object is active");
        GameObject asd = GameObject.Find("keyPrompt");
        asd.SetActive(true);
    }   
     
    void OnTriggerStay(Collider other)  
    {
        Debug.Log ("Object is Currently Active");
    }

    void OnTriggerExit(Collider other) 
    {
        Debug.Log ("Object is inactive!");
        
    }
}
