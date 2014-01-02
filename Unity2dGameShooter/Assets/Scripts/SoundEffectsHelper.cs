﻿using UnityEngine;
using System.Collections;
/// <summary>
/// Create instance of sounds
/// </summary>
public class SoundEffectsHelper : MonoBehaviour {


    public static SoundEffectsHelper Instance;
    public AudioClip explosionSound;
    public AudioClip playerShotSound;
    public AudioClip enemyShotSound;

    void Awake()
    {
        if(Instance !=null)
        {

            Debug.LogError("Multiple instances of SoundEffectsHelper!");
        }
        Instance = this;
    }

    public void MakeExplosionSound()
    {
        MakeSound(explosionSound);
    }

    public void MakePlayerShotSound()
    {
        MakeSound(playerShotSound);
    }

    public void MakeEnemyShotSound()
    {
        MakeSound(enemyShotSound);
    }

    /// <summary>
    /// Play a given sound
    /// </summary>
    /// <param name="originalClip"></param>
    private void MakeSound(AudioClip originalClip)
    {
        // As it is not 3D audio clip, position doesn't matter.
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }
}
