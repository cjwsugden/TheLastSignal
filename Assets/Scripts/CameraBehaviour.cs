using Unity.Mathematics;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

    public Transform player;        // assign Player object
    public Transform background;    // assign Background sprite

    private float halfCamWidth;
    private float halfBgWidth;

    void Start()
    {
        Camera cam = Camera.main;

        halfCamWidth = cam.orthographicSize * cam.aspect;

        SpriteRenderer bgRenderer = background.GetComponent<SpriteRenderer>();
        halfBgWidth = bgRenderer.bounds.extents.x;
    }

    void LateUpdate()
    {
        if (player == null || background == null) return;

        float targetX = player.position.x;

        // Clamp camera horizontally
        float minX = background.position.x - halfBgWidth + halfCamWidth;
        float maxX = background.position.x + halfBgWidth - halfCamWidth;
        float clampedX = Mathf.Clamp(targetX, minX, maxX);

        // Camera Y stays fixed at center of background
        float camY = background.position.y;
        float camZ = transform.position.z;

        transform.position = new Vector3(clampedX, camY, camZ);
    }
}
