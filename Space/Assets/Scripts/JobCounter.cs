using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobCounter : MonoBehaviour
{
    public GameObject TM5;
    public GameObject TM6;
    public GameObject TM7;
    public GameObject TM8;
    public GameObject TMcama;
    public static int contador = 0;

    void Update()
    {
        if(contador >= 4)
        {
            TM5.gameObject.SetActive(false);
            TM6.gameObject.SetActive(false);
            TM7.gameObject.SetActive(false);
            TM8.gameObject.SetActive(false);
            TMcama.gameObject.SetActive(true);
        }
    }
}
