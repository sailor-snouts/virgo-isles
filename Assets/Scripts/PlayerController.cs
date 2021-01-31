using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public enum Direction {NONE, CLOCKWISE, COUNTER_CLOCKWISE}

    private Direction sailsDirection = Direction.NONE;
    private Direction boatDirection = Direction.NONE;
    [SerializeField] private GameObject sails = null;
    [SerializeField] private GameObject flag = null;
    [SerializeField] private float boatRotationSpeed = 10f;
    [SerializeField] private float sailsRotationSpeed = 10f;

    public void RotateSailsClockwise(InputAction.CallbackContext context)
    {
        this.sailsDirection = context.ReadValueAsButton() ? Direction.CLOCKWISE : Direction.NONE; 
    }
    
    public void RotateSailsCounterClockwise(InputAction.CallbackContext context)
    {
        this.sailsDirection = context.ReadValueAsButton() ? Direction.COUNTER_CLOCKWISE : Direction.NONE; 
    }

    public void RotateBoatClockwise(InputAction.CallbackContext context)
    {
        this.boatDirection = context.ReadValueAsButton() ? Direction.CLOCKWISE : Direction.NONE; 
    }
    
    public void RotateBoatCounterClockwise(InputAction.CallbackContext context)
    {
        this.boatDirection = context.ReadValueAsButton() ? Direction.COUNTER_CLOCKWISE : Direction.NONE; 
    }

    void Update()
    {
        if (this.sailsDirection != Direction.NONE)
        {
            Vector3 sailsRotation = this.sailsDirection == Direction.CLOCKWISE ? Vector3.up : Vector3.down;
            this.sails.transform.Rotate(sailsRotation * (Time.deltaTime * this.sailsRotationSpeed));
        }
        if (this.boatDirection != Direction.NONE)
        {
            Vector3 boatRotation = this.boatDirection == Direction.CLOCKWISE ? Vector3.up : Vector3.down;
            this.gameObject.transform.Rotate(boatRotation * (Time.deltaTime * this.sailsRotationSpeed));
        }
    }
}
