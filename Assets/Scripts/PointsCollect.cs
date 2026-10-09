using UnityEngine;
using System.Collections;

public class PointsCollect : MonoBehaviour
{

    // Variable to point animations component (Animator)
    private Animator animatorPoint;

    void Awake(){

        // Component reference animator
        animatorPoint = GetComponent<Animator>();

    }
  
    void OnTriggerEnter2D(Collider2D col){

        // Check if the object that collided has the tag "JellyFish"
        if(col.CompareTag("JellyFish")){

            // Play destroy (scale down) animation
            animatorPoint.SetBool("canScale", true);

            // Add points to score
            UIManager.AddPoints();

            // Play point collect sound
            AudioManager.instanceSound.PlayPointSound();

            // Start coroutine to delay and destroy point object
            StartCoroutine(PointDestroy());

        }

        // Check if the object that collided has the tag "Fish"
        if(col.CompareTag("Fish")){

            // Destroy point in the same place that a fish spawn
            Destroy(gameObject);

        }

    }

    IEnumerator PointDestroy(){

        // Wait 0.5 seconds and destroy gameobject
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);

    }

}
