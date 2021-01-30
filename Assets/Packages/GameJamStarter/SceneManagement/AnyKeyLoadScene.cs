using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnyKeyLoadScene : MonoBehaviour
{
    private InputAction anyKeyAction = null;
    [SerializeField] private string nextScene = "";

    private void Awake()
    {
        this.anyKeyAction = new InputAction(binding: "/*/<button>");
        this.anyKeyAction.performed += OnAnyKey;
    }

    private void OnEnable()
    {
        this.anyKeyAction.Enable();
    }

    private void OnDisable()
    {
        this.anyKeyAction.Disable();
    }

    private void OnDestroy()
    {
        this.anyKeyAction.performed -= OnAnyKey;
    }

    private void OnAnyKey(InputAction.CallbackContext callbackContext)
    {
        LoadScene.Instance.Load(nextScene);
    }
}