using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    // Arrays to players and fishes spawnwers components (Transform)
    public Transform[] playersSpawnPoints;
    public Transform[] fishesSpawnPoints;

    // Array to turtles prefabs components (GameObject)
    public GameObject[] turtlesPrefabs;

    // Variables to player and fish prefabs components (GameObject)
    public GameObject playerPrefab;
    public GameObject fishPrefab;

    // Variable to player position, turtles count and random positions to fishes
    private int playerPosition;
    private int turtleCount = 0;
    private int randomFish;

    // Variable to check repeated fishes
    private bool repeatedFish;

    // Array to fishes positions
    public int[] fishPosition = new int[5];

    void Start()
    {

        // Call spawn methods to create player / turtles and fishs
        SpawnPlayers();
        SpawnFishes();
        
    }

    void SpawnPlayers(){

        // Random integer number (0 to 3)
        playerPosition = Random.Range(0,4);

        // Scroll through players (player and fishes) spawner array
        for(int i=0; i < playersSpawnPoints.Length; i++){

            // Check if isn't the player position
            if(i != playerPosition){

                // Create a turtle
                Instantiate(turtlesPrefabs[turtleCount], playersSpawnPoints[i]);
                
                // Increase turtle count
                turtleCount++;

            }else{

                // Create player
                Instantiate(playerPrefab, playersSpawnPoints[i]);

            }

        }

    }

    void SpawnFishes(){

        // Scroll through fishes spawner array
        for (int i = 0; i < fishPosition.Length; i++)
        {

            // Loop to creat fishes
            do{            
                
                // Reset boolean to repeated fish
                repeatedFish = false;

                // Get a random number (0-9)
                randomFish = Random.Range(0, 10);

                // Loop to check repeated fish
                for (int j=0; j < i; j++)
                {

                    // Check if fish is repeated
                    if (fishPosition[j] == randomFish)
                    {

                        // Set fish is repeated
                        repeatedFish = true;

                        // Stop loop
                        break;

                    }
                }

            } while (repeatedFish);

            // Add fish position to array
            fishPosition[i] = randomFish;

            // Create a fish in that position
            Instantiate(fishPrefab, fishesSpawnPoints[randomFish]);
        }

    }

}