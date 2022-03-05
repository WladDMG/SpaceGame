using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobCounter : MonoBehaviour
{
    [SerializeField]
    public static int contador = 0;

    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(contador);
       
    }
}
