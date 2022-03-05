using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField]
    public GameObject gameObjectTela;
    public GameObject gameObjectUI;
    
    public void OnInteraction()
    {
        gameObjectTela.SetActive(true);
        gameObjectUI.SetActive(false);
        
    }
}
