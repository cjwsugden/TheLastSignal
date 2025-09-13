using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform background;   // assign your background sprite here
    public float speed = 5f;

    private float halfBgWidth;

    void Start()
    {
        // Get background horizontal bounds
        SpriteRenderer bgRenderer = background.GetComponent<SpriteRenderer>();
        halfBgWidth = bgRenderer.bounds.extents.x;
    }

    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");

        // Horizontal-only movement
        rb.linearVelocity = new Vector2(xInput * speed, 0f); // Y = 0

        // Clamp X position so player stays inside background
        float clampedX = Mathf.Clamp(transform.position.x,
            background.position.x - halfBgWidth,
            background.position.x + halfBgWidth);

        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}