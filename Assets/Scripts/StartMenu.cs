using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private string mainScene = "Main";
    [SerializeField] private string settingsScene = "Settings";
    [SerializeField] private string howToPlayScene = "HowToPlay";
    [SerializeField] private string CreditsScene = "Credits";
    
    public void OnClickPlay()
    {
        LoadScene.Instance.Load(this.mainScene);
    }
    
    public void OnClickSettings()
    {
        LoadScene.Instance.Load(this.settingsScene);
    }
    
    public void OnClickHowToPlay()
    {
        LoadScene.Instance.Load(this.howToPlayScene);
    }
    
    public void OnClickCredits()
    {
        LoadScene.Instance.Load(this.CreditsScene);
    }
    
    public void OnClickExit()
    {
        Application.Quit();
    }
}
