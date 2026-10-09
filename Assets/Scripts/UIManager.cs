using UnityEngine;
using System.Collections;
using TMPro;

public class UIManager : MonoBehaviour
{

    // Variable to UI game time, fishes and score (points)
    public static int gameTimer = 60;
    public static int playerFishes = 0;
    public static int playerScore = 0;

    // Variable to text components (TextMeshPro)
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI fishesText;
    public TextMeshProUGUI scoreText;

    // Variable to panel component (Panel)
    public GameObject GameOverPanel;

    // Variable to text component (TextMeshPro)
    public TextMeshProUGUI winnerText;

    // Variable to control game loop
    public static bool gameOver = false;

    private bool canPlay = true;

    void Awake(){

        // Show game over panel 
        GameOverPanel.SetActive(false);

        // Reset game loop and variables
        gameOver = false;      
        gameTimer = 60;
        playerFishes = 0;
        playerScore = 0;

    }

    void Start()
    {

        // Starts countdown timer coroutine
        StartCoroutine(TimerCount());
        
    }

    void Update()
    {

        // Sets UI text to points (score)
        scoreText.text = "SCORE: " + playerScore.ToString();
        
        // Sets UI text to fishes
        fishesText.text = "FISHES: " + playerFishes.ToString();

        // Check if jellyfish collect total fishes
        if(playerFishes == 5){

            // Game is over
            gameOver = true;

        }

        // Check if game is over
        if(gameOver){

            // Check conditions to jellyfish win
            if(gameTimer < 1 || playerFishes == 5){

                if(canPlay){

                    // Play sound game over
                    AudioManager.instanceSound.PlayGameOverSound();

                    // Stop condition to play in loop
                    canPlay = false;

                }

                // Show jellyfish as winner
                winnerText.text = "Jellyfish won!";

            }else{

                if(canPlay){

                    // Play sound game over
                    AudioManager.instanceSound.PlayGameOverSound();

                    // Stop condition to play in loop
                    canPlay = false;

                }

                // Show turtles as winner
                winnerText.text = "Turtles won!";

            }

        }

    }

    IEnumerator TimerCount(){

        // Condition to game control gametime countdown and color
        while (gameTimer >= 0 && !gameOver)
        {

            // Sets UI text to time
            timerText.text = "TIME: " + gameTimer.ToString();

            // Wait 1.0 second and set minus one to timer  
            yield return new WaitForSeconds(1f);
            gameTimer--;

            // Checks if timer is in the final countdown (10, 9, 8...)
            if(gameTimer <= 10){

                // Set UI text timer to a "red" variation 
                timerText.color = new Color32(238, 72, 72, 255);

            }

        }

        // Game is over
        gameOver = true;

        // Show game over panel 
        GameOverPanel.SetActive(true);

    }

    public static void AddPoints(){

        // Add points
        playerScore += 10;

    }

    public static void AddFishes(){

        // Add points and fishes
        playerScore += 50;
        playerFishes++;

    }

}
