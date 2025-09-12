using UnityEngine;

public class Tablet : MonoBehaviour, IInteractable
{
    public Sprite crewPhoto;
    public string crewName;
    [TextArea(3, 6)]
    public string memoryText;

    public MemoryUIManager memoryUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void Interact()
    {
        memoryUI.ShowMemory(crewPhoto, crewName, memoryText);
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
