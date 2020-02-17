using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{

    public AudioSource buttonAudio;


    public void OnButtonClick()
    {
        buttonAudio.Play();
    }
    public void StopStartAudio()
    {
        if (buttonAudio.isPlaying)
        {
            buttonAudio.Stop();
        }
        else
        {
            buttonAudio.Play();
        }
    }
}
