using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    
    // Variable to instance of this class
    public static AudioManager instanceSound;

    // Variable to audio components (AudioSouce and AudioClip)
    public AudioSource soundsSource;
    public AudioClip soundPointCollect;
    public AudioClip soundFishCollect;
    public AudioClip soundUIButton;
    public AudioClip soundGameOver;
    public AudioClip soundLogoSplash;
    public AudioClip soundTitle;
    public AudioClip soundSlogan;
    public AudioClip soundSlideButton;
    public AudioClip soundBubble;


    // Variable to audio components (AudioClip)
    public AudioClip menuMusic;
    public AudioClip gameMusic;

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

    public void PlayGameMusic()
    {

        // Play game music
        soundsSource.clip = gameMusic;

    }

    public void PlayMenuMusic()
    {

        // Play menu music
        soundsSource.clip = menuMusic;

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
        soundsSource.PlayOneShot(soundUIButton);

    }

    public void PlayGameOverSound()
    {

        // Play sound game over
        soundsSource.PlayOneShot(soundGameOver);

    }

    public void PlayLogoSound()
    {

        // Play sound logo
        soundsSource.PlayOneShot(soundLogoSplash);

    }

    public void PlayTitleSound()
    {

        // Play sound title
        soundsSource.PlayOneShot(soundTitle);

    }

    public void PlaySloganSound()
    {

        // Play sound slogan
        soundsSource.PlayOneShot(soundSlogan);

    }

    public void PlaySlideButtonSound()
    {

        // Play sound slide button
        soundsSource.PlayOneShot(soundSlideButton);

    }

    public void PlayBubbleSound()
    {

        // Play sound bubble
        soundsSource.PlayOneShot(soundBubble);

    }

}
