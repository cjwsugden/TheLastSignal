using UnityEngine;

public class Tablet : MonoBehaviour, IInteractable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void Interact()
    {
        Debug.Log("Tablet interacted with.");
    }

    public bool CanInteract()
    {
        return true;
    }

    void Update()
    {
        
    }
}
