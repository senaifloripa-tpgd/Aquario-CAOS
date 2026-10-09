using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   
    public void StartGame(){

        // Play click menu sound 
        AudioManager.instanceSound.PlayClickMenuSound();

        // Reload game scene
        SceneManager.LoadScene("Game");

    }

    public void MainMenu(){

        // Play click menu sound 
        AudioManager.instanceSound.PlayClickMenuSound();

        // Load main menu scene
        SceneManager.LoadScene("MainMenu");

    }

}
