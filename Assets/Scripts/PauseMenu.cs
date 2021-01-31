using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private PlayerInput controls = null;
    [SerializeField] private GameObject canvas = null;
    [SerializeField] private string SettingsScene = "Settings";
    [SerializeField] private string TitleScene = "Title";

    public void Pause()
    {
        this.controls.enabled = false;
        this.canvas.SetActive(true);
    }

    public void Resume()
    {
        this.controls.enabled = true;
        this.canvas.SetActive(false);
    }

    public void Settings()
    {
        LoadScene.Instance.Load(this.SettingsScene);
    }

    public void Quit()
    {
        LoadScene.Instance.Load(this.TitleScene);
    }
}
