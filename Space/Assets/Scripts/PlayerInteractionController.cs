using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteractionController : MonoBehaviour
{
    public float maxDistance = 5;
    public LayerMask interactableLayers;
    public Button interactButton;


    private Interactable currentInteractable;

    private void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, maxDistance, interactableLayers))
        {
            currentInteractable = hit.collider.GetComponent<Interactable>();
        }
        else
        {
            currentInteractable = null;
        }
        interactButton.interactable = currentInteractable != null;
    }

    public void Interact()
    {
        if (currentInteractable)
        {
            currentInteractable.OnInteraction();

        }
    }
}
