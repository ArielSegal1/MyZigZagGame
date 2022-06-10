using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public AudioManager instance;


    private void Awake() {
        if(instance == null){
            instance = this;
        }
        else{
            Destroy(gameObject);
            return;
        }

        foreach(Sound s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    private void Start() {
        Play("MainTheme");
    }
    
    
       public void Play(string name){
           Sound s = Array.Find(sounds, sound => sound.name == name);
           if(s == null){
               Debug.LogError("The sound name " + name + " doesn't exist!");
               return;
           }
           s.source.Play();
       }
}
