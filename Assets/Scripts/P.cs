using UnityEngine;

public class LockInDirection: MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    
    public SpriteRenderer spr;

    public Sprite lookRightImage;
    public Sprite lookUpImage;

    private float horizontalInput;
    private float verticalInput;

    // Collecting inputs
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
       

    // Updating the sprite
    void FixedUpdate()
    {
        if (horizontalInput < 0)
        {
            spr.sprite = lookRightImage;
            spr.flipX=true;
        }
        if (horizontalInput > 0)
        {
            spr.sprite = lookRightImage;
            spr.flipX = false;
        }
        if (verticalInput < 0)
        {
            spr.sprite = lookUpImage;
            spr.flipY = true;
        }
        if (verticalInput > 0)
        {
            spr.sprite = lookUpImage;
            spr.flipY = false;
        }
        rb.position += Vector2.right * horizontalInput * moveSpeed * Time.fixedDeltaTime;
        rb.position += Vector2.up * verticalInput * moveSpeed * Time.fixedDeltaTime;
    }
}