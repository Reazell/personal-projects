using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour {

    public AudioMixer masterMixer;

    public void SetMasterVolume(float masterLvl)
    {
        masterMixer.SetFloat("masterVolume", masterLvl);
    }
}
