using UnityEngine;

public class Laptop : MonoBehaviour, IInteractable
{
    public Sprite crewPhoto;
    public string crewName;
    [TextArea(3, 7)]
    public string memoryText;

    public MemoryUIManager memoryUI;

    public void Interact()
    {
        memoryUI.ShowMemory(crewPhoto, crewName, memoryText);
    }

    public bool CanInteract()
    {
        return true;
    }
}
