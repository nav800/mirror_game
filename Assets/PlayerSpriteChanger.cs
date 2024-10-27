using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // Reference to the Sprite Renderer
    public Sprite upSprite; // Sprite for moving up
    public Sprite downSprite; // Sprite for moving down
    public Sprite leftSprite; // Sprite for moving left
    public Sprite rightSprite; // Sprite for moving right
    private bool facingLeft;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Automatically get the SpriteRenderer component
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // Get input for left/right movement
        float moveVertical = Input.GetAxis("Vertical");     // Get input for up/down movement

        Debug.Log($"Horizontal: {moveHorizontal}, Vertical: {moveVertical}"); // Log input values

        ChangeSprite(moveHorizontal, moveVertical); // Call the function to change the sprite
    }

    public void ChangeSprite(float moveHorizontal, float moveVertical)
    {
        facingLeft = false;

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
            spriteRenderer.sprite = leftSprite;
            facingLeft = true;

            if (facingLeft)
            {
                Vector2 localScale = transform.localScale;
                localScale.x *= -1;
                transform.localScale = localScale;
            }
        }
        else if (moveHorizontal > 0)
        {
            spriteRenderer.sprite = rightSprite;
            facingLeft = false;

            if (!facingLeft)
            {
                Vector2 localScale = transform.localScale;
                localScale.x *= -1;
                transform.localScale = localScale;
            }
        }
    }
}
