using UnityEngine;
using System.Collections;

public class MenuSoundsManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        StartCoroutine(SoundsManager());
        
    }

    IEnumerator SoundsManager(){

        // 
        yield return new WaitForSeconds(0.5f);
        AudioManager.instanceSound.PlayTitleSound();
        yield return new WaitForSeconds(2.3f);
        AudioManager.instanceSound.PlaySloganSound();
        yield return new WaitForSeconds(0.5f);
        AudioManager.instanceSound.PlaySlideButtonSound();
        yield return new WaitForSeconds(0.5f);
        AudioManager.instanceSound.PlaySlideButtonSound();
        yield return new WaitForSeconds(0.5f);
        AudioManager.instanceSound.PlaySlideButtonSound();
        yield return new WaitForSeconds(0.5f);
        AudioManager.instanceSound.PlaySlideButtonSound();
        yield return new WaitForSeconds(0.5f);
        AudioManager.instanceSound.PlayBubbleSound();
        yield return new WaitForSeconds(0.5f);
        AudioManager.instanceSound.PlayBubbleSound();
        yield return new WaitForSeconds(0.5f);
        AudioManager.instanceSound.PlayBubbleSound();      

    }
}
