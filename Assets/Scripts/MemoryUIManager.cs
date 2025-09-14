using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MemoryUIManager : MonoBehaviour
{
    public Image crewImage;
    public TMP_Text crewNameText;
    public TMP_Text memoryText;

    private bool isOpen = false;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.SetActive(false); //starts hidden
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen && Input.GetKeyDown(KeyCode.Escape))
        {
            CloseMemory();
        }
    }

    public void ShowMemory(Sprite crewSprite, string crewName, string memory)
    {
        crewImage.sprite = crewSprite;
        crewNameText.text = crewName;
        memoryText.text = memory;

        gameObject.SetActive(true);
        isOpen = true;

        Time.timeScale = 0f; // Pause the game
        player.GetComponent<PlayerMovement>().enabled = false; // Disable player controls
    }
    
    public void CloseMemory()
    {
        gameObject.SetActive(false);
        isOpen = false;

        Time.timeScale = 1f; // Resume the game
        if(player != null)
        {
            player.GetComponent<PlayerMovement>().enabled = true; // Enable player controls
        }
    }
}