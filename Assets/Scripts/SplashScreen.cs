using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{

    void Start()
    {

        Invoke("LogoSound", 0.2f);
        Invoke("MainMenu", 4f);
        
    }

    public void MainMenu(){

        // Load main menu scene
        SceneManager.LoadScene("Menu");

    }

    public void LogoSound(){

        // Play logo sound 
        AudioManager.instanceSound.PlayLogoSound();

    }

}
