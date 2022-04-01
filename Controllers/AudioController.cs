using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private static AudioController instance;
    public static AudioController Instance{
        get{
            if(instance == null){
                instance = FindObjectOfType<AudioController>();
            }
            return instance;
        }
    }
    [SerializeField] AudioSource sfxSource, musicSource, ambientSource;

    public void PlaySound(string name){
        var audio = ResourceController.GetAudio(name);
        if(audio == null)return;
        sfxSource.PlayOneShot(audio);
    }
}
