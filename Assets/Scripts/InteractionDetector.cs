using System;
using System.Collections.Generic;
using UnityEngine;

public class InteractionDetector : MonoBehaviour
{
    private List<IInteractable> interactables = new List<IInteractable>();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && interactables.Count > 0)
        {
            Debug.Log("E key pressed. Attempting to interact.");
            var interactable = interactables[0];
            if (interactable.CanInteract())
            {
                interactable.Interact();
                Debug.Log("Interacted with: " + interactable);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var interactable = other.GetComponent<IInteractable>();
        if (interactable != null && interactable.CanInteract())
        {
            interactables.Add(interactable);
            Debug.Log("Added interactable: " + other.name);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        var interactable = other.GetComponent<IInteractable>();
        if (interactables.Contains(interactable))
        {
            interactables.Remove(interactable);
            Debug.Log("Removed interactable: " + other.name);
        }
    }
}
