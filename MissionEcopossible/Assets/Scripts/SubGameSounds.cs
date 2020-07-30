using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubGameSounds : MonoBehaviour
{
    public AudioSource PickUp;
    public AudioSource LevelDone;

    public void PlayPickUp(){
        PickUp.Play();
    }

    public void PlayLevelDone(){
        LevelDone.Play();
    }
}
