using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class LoadSaveData : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer = null;

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        int index = PlayerPrefs.GetInt("Resolution", -1);
        if(index >= 0) Screen.SetResolution(Screen.resolutions[index].width, Screen.resolutions[index].height, Screen.fullScreen);
        
        int quality = PlayerPrefs.GetInt("Quality", -1);
        if(quality >= 0) QualitySettings.SetQualityLevel(quality);
        
        int isFullscreen = PlayerPrefs.GetInt("FullScreen", -1);
        if(isFullscreen >= 0) Screen.fullScreen = isFullscreen == 1 ? true : false;
        
        float volume = PlayerPrefs.GetFloat("MasterVolume", -1f);
        if(volume >= 0) this.mixer.SetFloat("MasterVolume", Mathf.Log10(volume) * 20f);
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
