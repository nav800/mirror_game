using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // Reference to the Sprite Renderer
    public Sprite upSprite; // Sprite for moving up
    public Sprite downSprite; // Sprite for moving down
    public Sprite leftSprite; // Sprite for moving left
    public Sprite rightSprite; // Sprite for moving right
    private bool facingLeft = false;

    public void FlipSprite()
    {
        // Toggle the facing direction
        facingLeft = !facingLeft;

        // Get the current local scale
        Vector3 localScale = transform.localScale;

        // Multiply x scale by -1 to flip the sprite
        localScale.x *= -1;

        // Apply the new local scale
        transform.localScale = localScale;
    }

    // Example: Flip when moving in a new direction
    public void Move(float direction)
    {
        Debug.Log(direction > 0);
        // Check if direction change requires a flip
        if ((direction > 0 && facingLeft) || (direction < 0 && !facingLeft))
        {
            FlipSprite();
        }
    }

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Automatically get the SpriteRenderer component
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // Get input for left/right movement
        float moveVertical = Input.GetAxis("Vertical");     // Get input for up/down movement

        Move(moveHorizontal);

        Debug.Log($"Horizontal: {moveHorizontal}, Vertical: {moveVertical}");

        ChangeSprite(moveHorizontal, moveVertical); // Call the function to change the sprite
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
            spriteRenderer.sprite = rightSprite;
        }
        else if (moveHorizontal > 0)
        {
            spriteRenderer.sprite = rightSprite;
        }
    }
}
