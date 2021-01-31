using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CinemachineFreeLook))]
public class FreeLookAddOn : MonoBehaviour
{
    [SerializeField] private float LookSpeed = 1f;
    [SerializeField] private bool invertY = false;
    private CinemachineFreeLook freeLookComponent;

    public void Start()
    {
        this.freeLookComponent = GetComponent<CinemachineFreeLook>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        Vector2 lookMovement = context.ReadValue<Vector2>().normalized;
        lookMovement.y = this.invertY ? -lookMovement.y : lookMovement.y;
        lookMovement.x = lookMovement.x * 180f; 
        this.freeLookComponent.m_XAxis.Value += lookMovement.x * LookSpeed * Time.deltaTime;
        this.freeLookComponent.m_YAxis.Value += lookMovement.y * LookSpeed * Time.deltaTime;
    }
}