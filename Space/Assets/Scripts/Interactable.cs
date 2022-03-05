using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField]
    public GameObject gameObject;
    public GameObject gameObjectUI;
    
    public void OnInteraction()
    {
        gameObject.SetActive(true);
        gameObjectUI.SetActive(false);
        JobCounter.contador++;
    }
}
