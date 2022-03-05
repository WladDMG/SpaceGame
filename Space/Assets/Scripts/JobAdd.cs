using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JobAdd : MonoBehaviour
{
    public GameObject gameObject;
    public void AddJob()
    {
       JobCounter.contador++;
       Destroy(gameObject);
        Debug.Log(JobCounter.contador);        
    }
   
}
