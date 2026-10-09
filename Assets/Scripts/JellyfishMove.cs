using UnityEngine;

public class JellyfishMove : MonoBehaviour
{
    // Variables to horizontal and vertical input
    private float horizontalInput;
    private float verticalInput;

    // Variable to player speed
    private float moveSpeed = 5f;

    // Variable to player physics component (Rigidbody2D)
    private Rigidbody2D playerPhysics;

    // Variable to player sprite component (SpriteRenderer)
    private SpriteRenderer playerSprite;

    void Awake()
    {        

        // Component references rigidbody and spriterenderer
        playerPhysics = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();

    }

    void Update()
    {

        // Check if game isn't over
        if(!UIManager.gameOver){

            // Axis inputs to variables
            horizontalInput = Input.GetAxis("HorizontalP1");
            verticalInput = Input.GetAxis("VerticalP1");

            // Calculate inputs x speed in new vector2 and use it to set linear velocity of player physics 
            playerPhysics.linearVelocity = new Vector2(horizontalInput * moveSpeed, verticalInput * moveSpeed);

        }else{

            // Stop player one movement
            playerPhysics.constraints = RigidbodyConstraints2D.FreezePositionX;
            playerPhysics.constraints = RigidbodyConstraints2D.FreezePositionY;
            playerPhysics.constraints = RigidbodyConstraints2D.FreezeRotation;

        }

    }

    void OnCollisionEnter2D(Collision2D col){

        // Check if the object that collided has the tag "Turtle" 
        if(col.gameObject.CompareTag("Turtle")){

            // Set player color end game (red)
            playerSprite.color = new Color32(238, 72, 72, 255);

        }

    }
    
}
