using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField]
    public GameObject gameObjectTelaOn;
    public GameObject gameObjectUIOFF;
    
    public void OnInteraction()
    {
        gameObjectTelaOn.SetActive(true);
        gameObjectUIOFF.SetActive(false);
        
    }
}
