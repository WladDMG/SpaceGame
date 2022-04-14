using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggercorredor : MonoBehaviour
{
    public GameObject GameObject1On;
    public GameObject GameObject2OFF;
    public GameObject GameObject1OFF;
    public GameObject LuzOn;
    public GameObject LuzOff;
    public Collider colider;
    
    private void OnTriggerEnter(Collider collider)
    {
        GameObject1On.SetActive(true);
        GameObject1OFF.SetActive(false);
        GameObject2OFF.SetActive(false);
        LuzOn.SetActive(true);
        LuzOff.SetActive(false);
    }
}
