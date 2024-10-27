using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // Reference to the Sprite Renderer

    public Sprite[] upSprites; // Array of sprites for moving up
    public Sprite[] downSprites; // Array of sprites for moving down
    public Sprite[] leftSprites; // Array of sprites for moving left
    public Sprite[] rightSprites; // Array of sprites for moving right

    public float animationSpeed = 0.1f; // Time between frames
    private int currentFrame; // Current animation frame
    private float timer; // Timer to track frame updates

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

        Debug.Log($"Horizontal: {moveHorizontal}, Vertical: {moveVertical}"); // Log input values

        // Call function to animate the walking sprites based on direction
        AnimateMovement(moveHorizontal, moveVertical);
    }

   public void AnimateMovement(float moveHorizontal, float moveVertical)
{
    Sprite[] currentSprites = null;
    bool flip = false; // Determines if we should flip the sprite

    // Determine which set of sprites to use based on input
    if (moveVertical > 0)
    {
        currentSprites = upSprites;
    }
    else if (moveVertical < 0)
    {
        currentSprites = downSprites;
    }
    else if (moveHorizontal != 0)
    {
        currentSprites = rightSprites; // Always use right-facing sprites
        flip = moveHorizontal < 0; // Flip sprite if moving left
    }

    if (currentSprites != null && currentSprites.Length > 0)
    {
        // Update the timer and switch frames if needed
        timer += Time.deltaTime;
        if (timer >= animationSpeed)
        {
            currentFrame = (currentFrame + 1) % currentSprites.Length; // Cycle frames
            spriteRenderer.sprite = currentSprites[currentFrame]; // Set sprite to current frame
            spriteRenderer.flipX = flip; // Flip sprite if moving left
            timer = 0f; // Reset timer
        }
    }
    else
    {
        // Reset to the first frame if no input
        currentFrame = 0;
        if (currentSprites != null && currentSprites.Length > 0)
        {
            spriteRenderer.sprite = currentSprites[currentFrame];
        }
        spriteRenderer.flipX = false; // Reset flip when idle
    }
}

    }

