using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioMixer _compAudioMixer;
    [SerializeField] private Slider sliderMaster;
    [SerializeField] private Slider sliderMusic;
    [SerializeField] private Slider sliderSfx;
    [SerializeField] private SliderConfig audioSettings;

    public void SetVolumenMaster()
    {
        float volumen = sliderMaster.value;
        _compAudioMixer.SetFloat("Master", Mathf.Log10(volumen) * 20);
        //audioSettings.master = Mathf.Log10(volumen) * 20;
    }
    public void SetVolumenMusic()
    {
        float volumen = sliderMusic.value;
        _compAudioMixer.SetFloat("Music", Mathf.Log10(volumen) * 20);
        //audioSettings.music = Mathf.Log10(volumen) * 20;
    }
    public void SetVolumenSfx()
    {
        float volumen = sliderSfx.value;
        _compAudioMixer.SetFloat("SFX", Mathf.Log10(volumen) * 20);
        //audioSettings.sfx = Mathf.Log10(volumen) * 20;
    }
    // intento de usar el scriptable objects para que el slider bar en la segunda escena se quede como esta en la primera escena :c 
}
