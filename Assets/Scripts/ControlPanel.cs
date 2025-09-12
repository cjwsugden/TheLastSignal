using UnityEngine;

public class ControlPanel : MonoBehaviour, IInteractable
{
    private bool isActive = false;
    public GameObject player;
    public GameObject puzzleUI;

    void Start()
    {
        Debug.Log("Control Panel initialized. Active state: " + isActive);
    }

    void Update()
    {
        if (isActive && Input.GetKeyDown(KeyCode.Escape))
        {
            ClosePuzzle();
        }
    }

    public void Interact()
    {
        if (isActive)
        {
            ClosePuzzle();
        }
        else
        {
            OpenPuzzle();
        }
    }

    public bool CanInteract()
    {
        return true;
    }

    void OpenPuzzle()
    {
        isActive = true;
        puzzleUI.SetActive(true);
        Time.timeScale = 0f;
        if (player != null)
        {
            player.GetComponent<PlayerMovement>().enabled = false;
        }
        Debug.Log("Puzzle opened and game paused.");
    }

    void ClosePuzzle()
    {
        isActive = false;
        puzzleUI.SetActive(false);
        Time.timeScale = 1f;
        if (player != null)
        {
            player.GetComponent<PlayerMovement>().enabled = true;
        }
        Debug.Log("Puzzle closed and game resumed.");
    }
}
