using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXManager : MonoBehaviour
{

    public AudioSource audioSource;
    public List<AudioClip> allSounds;
    public List<Toggle> toggles;
    private List<AudioClip> chosenSounds = new List<AudioClip>();

    public static SFXManager sfxInstance;

    private void Awake()
    {
        sfxInstance = this;
    }

    public void PlayRandomSoundFromList()
    {
        for (int i = 0; i < allSounds.Count; i++) // loop through sounds added via Inspector
        {
            if (toggles[i].GetComponent<Toggle>().isOn == true) // check if toggle with matching Index in on
            {
                chosenSounds.Add(allSounds[i]); // add to temporary choosen list
            }
        }
        if (chosenSounds.Count >= 1) // if any toggle is selected 
        {
            SFXManager.sfxInstance.audioSource.PlayOneShot(SFXManager.sfxInstance.chosenSounds[Random.Range(0, chosenSounds.Count)]); // play random sound out of 
            chosenSounds.Clear();
        }
    }

    public void ToggleBool(bool tog)
    {
        Debug.Log(tog);
    }

}
