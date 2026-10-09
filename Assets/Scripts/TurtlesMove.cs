using UnityEngine;

public class TurtlesMove : MonoBehaviour
{

    // Variables to horizontal and vertical input
    private float horizontalInput;
    private float verticalInput;

    // Variable to turtle speed
    private float moveSpeed = 3f;

    // Variable to turtle physics component (Rigidbody2D)
    private Rigidbody2D turtlePhysics;

    // Variable to turtle sprite component (SpriteRenderer)
    private SpriteRenderer turtleSprite;

    // Variable to turtle animator component (Animator)
    private Animator turtleAnimator;

    void Awake()
    {        

        // Component references rigidbody, spriterenderer and animator
        turtlePhysics = GetComponent<Rigidbody2D>();
        turtleSprite = GetComponent<SpriteRenderer>();
        turtleAnimator = GetComponent<Animator>();

    }

    void Update()
    {

        // Check if game isn't over
        if(!UIManager.gameOver){

            // Axis inputs to variables
            horizontalInput = Input.GetAxis("HorizontalP2");
            verticalInput = Input.GetAxis("VerticalP2");

            // Calculate inputs x speed in new vector2 and use it to set linear velocity of turtle physics 
            turtlePhysics.linearVelocity = new Vector2(horizontalInput * moveSpeed, verticalInput * moveSpeed);

        }else{

            // Stop turtles movement
            turtlePhysics.constraints = RigidbodyConstraints2D.FreezePositionX;
            turtlePhysics.constraints = RigidbodyConstraints2D.FreezePositionY;

        }

        // Check if turtle direction is right
        if(horizontalInput > 0){

            // Set flip X to false and animation to running
            turtleSprite.flipX = false;
            turtleAnimator.SetBool("isRunning", true);

        // Check if turtle direction is left
        }else  if(horizontalInput < 0){

            // Set flip X to true and animation to running
            turtleSprite.flipX = true;
            turtleAnimator.SetBool("isRunning", true);

        }else{

            // Sets animation to idle
            turtleAnimator.SetBool("isRunning", false);

        }

        // Check game time and total collected fishes conditions, to end game
        if(UIManager.gameTimer < 1 || UIManager.playerFishes == 5){

            // Set turtle color end game (red)
            turtleSprite.color = new Color32(238, 72, 72, 255);

        }
        
    }

    void OnCollisionEnter2D(Collision2D col){

        // Check if the object that collided has the tag "JellyFish" 
        if(col.gameObject.CompareTag("JellyFish")){

            // Game is over
            UIManager.gameOver = true;

        }

    }

}
