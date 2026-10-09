using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    // Variable to instance of this class
    public static AudioManager instanceSound;

    // Variable to audio components (AudioSouce and AudioClip)
    public AudioSource soundsSource;
    public AudioClip soundPointCollect;
    public AudioClip soundFishCollect;
    public AudioClip soundClickMenu;
    public AudioClip soundGameOver;

    void Awake()
    {

        // Check if an instance don't exists
        if (instanceSound == null){

            // Create a instance
            instanceSound = this;

            // Set to don't destroy
            DontDestroyOnLoad(gameObject);

        }else{

            // Destroy the instance
            Destroy(gameObject);

        }
    }

    public void PlayPointSound()
    {

        // Play sound point collect
        soundsSource.PlayOneShot(soundPointCollect);

    }

    public void PlayFishSound()
    {

        // Play sound fish collect
        soundsSource.PlayOneShot(soundFishCollect);

    }

    public void PlayClickMenuSound()
    {

        // Play sound click
        soundsSource.PlayOneShot(soundClickMenu);

    }

    public void PlayGameOverSound()
    {

        // Play sound game over
        soundsSource.PlayOneShot(soundGameOver);

    }

}
