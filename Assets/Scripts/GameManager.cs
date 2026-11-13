using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    void Start()
    {

        // Get scene that load
        Scene scene = SceneManager.GetActiveScene();

        // Show scene name 
        Debug.Log(scene.name);

        // Check if scene is game and play game music
        if (scene.name == "Game")
        {
            AudioManager.instanceSound.PlayGameMusic();
            AudioManager.instanceSound.soundsSource.Stop();
            AudioManager.instanceSound.soundsSource.Play();

        }

        // Check if scene is menu and play menu music
        if (scene.name == "Menu")
        {
            AudioManager.instanceSound.PlayMenuMusic();
            AudioManager.instanceSound.soundsSource.Stop();
            AudioManager.instanceSound.soundsSource.Play();

        }

    }

    public void StartGame(){

        // Play click menu sound 
        AudioManager.instanceSound.PlayClickMenuSound();

        // Load game scene
        SceneManager.LoadScene("Game");

    }

    public void MainMenu(){

        // Play click menu sound 
        AudioManager.instanceSound.PlayClickMenuSound();

        // Load main menu scene
        SceneManager.LoadScene("MainMenu");

    }

    public void MainMenuAfterSplash(){

        // Load main menu scene
        SceneManager.LoadScene("MainMenu");

    }

}
