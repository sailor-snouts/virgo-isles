using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public static LoadScene Instance { get; private set; }
    [SerializeField] private Animator animator = null;
    [SerializeField] private float waitTime = 2;
    private LinkedList<string> previousScenes;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        } else {
            Instance = this;
            this.previousScenes = new LinkedList<string>();
            this.previousScenes.AddLast(SceneManager.GetActiveScene().name);
            DontDestroyOnLoad(this);
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        animator.ResetTrigger("FadeTo");
        animator.SetTrigger("FadeFrom");
    }

    public void Load(string scene, bool async = false, bool additive = false)
    {
        this.previousScenes.AddLast(SceneManager.GetActiveScene().name);
        while(this.previousScenes.Count > 10)
            this.previousScenes.RemoveFirst();
        StartCoroutine(LoadRoutine(scene, async, additive));
    }

    public void LoadPreviousScene(bool async = false, bool additive = false)
    {
        string scene = this.previousScenes.Last.Value;
        this.previousScenes.RemoveLast();
        StartCoroutine(LoadRoutine(scene, async, additive));
    }

    IEnumerator LoadRoutine(string scene, bool async, bool additive)
    {
        animator.ResetTrigger("FadeFrom");
        animator.SetTrigger("FadeTo");
        yield return new WaitForSeconds(waitTime);
        if(async)
            SceneManager.LoadSceneAsync(scene, additive ? LoadSceneMode.Additive : LoadSceneMode.Single);
        else
            SceneManager.LoadScene(scene, additive ? LoadSceneMode.Additive : LoadSceneMode.Single);
    }
}
