using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer = null;
    private Resolution[] resolutions;
    [SerializeField] private TMP_Dropdown resolutionsDropdown = null;
    [SerializeField] private TMP_Dropdown qualityLevelDropdown = null;
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private Toggle fullescreenToggle = null;

    private void Start()
    {
        this.LoadResolutionValue();
        this.LoadVolume();
        this.LoadQuality();
        this.LoadFullscreen();
    }

    private void LoadResolutionValue()
    {
        int currentIndex = 0;
        List<string> options = new List<string>();
        for (int i = 0; i < Screen.resolutions.Length; i++)
        {
            if (Screen.resolutions[i].width == Screen.width && Screen.resolutions[i].height == Screen.height)
                currentIndex = i;
            options.Add(Screen.resolutions[i].ToString());
        }
        this.resolutions = Screen.resolutions;
        this.resolutionsDropdown.ClearOptions();
        this.resolutionsDropdown.AddOptions(options);
        this.resolutionsDropdown.value = currentIndex;
        this.resolutionsDropdown.RefreshShownValue();
    }

    public void SetResolution(int index)
    {
        Screen.SetResolution(this.resolutions[index].width, this.resolutions[index].height, Screen.fullScreen);
    }

    private void LoadVolume()
    {
        float volume;
        this.mixer.GetFloat("MasterVolume", out volume);
        this.volumeSlider.value = Mathf.Pow(10f, volume/20f);
    }
    
    public void SetVolume(float volume)
    {
        this.mixer.SetFloat("MasterVolume", Mathf.Log10(volume) * 20f);
    }

    public void LoadQuality()
    {
        this.qualityLevelDropdown.ClearOptions();
        this.qualityLevelDropdown.AddOptions(QualitySettings.names.ToList());
        this.qualityLevelDropdown.value = QualitySettings.GetQualityLevel();
        this.qualityLevelDropdown.RefreshShownValue();
    }
    
    public void SetQuality(int level)
    {
        QualitySettings.SetQualityLevel(level);
    }

    public void LoadFullscreen()
    {
        this.fullescreenToggle.isOn = Screen.fullScreen;
    }
    
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void LoadPreviousScene()
    {
        LoadScene.Instance.LoadPreviousScene();
    }
}
