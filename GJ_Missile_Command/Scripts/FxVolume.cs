using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class FxVolume : MonoBehaviour
{
    //////////////////////Volume Slider Function
    public AudioMixer fxmixer;

    public void SetVolume(float volume)
    {
        fxmixer.SetFloat("FxVolume", Mathf.Log10(volume) * 20);
    }
}
