using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // Reference to the Sprite Renderer
    public Sprite upSprite; // Sprite for moving up
    public Sprite downSprite; // Sprite for moving down
    public Sprite leftSprite; // Sprite for moving left
    public Sprite rightSprite; // Sprite for moving right

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Automatically get the SpriteRenderer component
        currentFrame = 0;
        timer = 0f;
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // Get input for left/right movement
        float moveVertical = Input.GetAxis("Vertical");     // Get input for up/down movement

        Move(moveHorizontal);

        Debug.Log($"Horizontal: {moveHorizontal}, Vertical: {moveVertical}");

        // Call function to animate the walking sprites based on direction
        AnimateMovement(moveHorizontal, moveVertical);
    }

    public void ChangeSprite(float moveHorizontal, float moveVertical)
    {
        // Change the sprite based on the movement direction
        if (moveVertical > 0)
        {
            spriteRenderer.sprite = upSprite; // Up
        }
        else if (moveVertical < 0)
        {
            spriteRenderer.sprite = downSprite; // Down
        }
        else if (moveHorizontal < 0)
        {
            spriteRenderer.sprite = leftSprite; // Left
        }
        else if (moveHorizontal > 0)
        {
            spriteRenderer.sprite = rightSprite; // Right
        }
    }
}
