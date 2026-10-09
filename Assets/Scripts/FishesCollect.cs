using UnityEngine;

public class FishesCollect : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col){

        // Check if the object that collided has the tag "JellyFish"
        if(col.CompareTag("JellyFish")){

            // Play fish collect sound 
            AudioManager.instanceSound.PlayFishSound();

            // Add points to score and fishes count
            UIManager.AddFishes();            

            // Destroy fish object
            Destroy(gameObject);

        }

    }

}
