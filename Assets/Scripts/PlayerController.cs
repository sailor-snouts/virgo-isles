﻿using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{
    public enum Direction {NONE, CLOCKWISE, COUNTER_CLOCKWISE}

    private Direction sailsDirection = Direction.NONE;
    private Direction boatDirection = Direction.NONE;
    [SerializeField] private GameObject body = null;
    [SerializeField] private GameObject sails = null;
    [SerializeField] private GameObject flag = null;
    [SerializeField] private float boatRotationSpeed = 1f;
    [SerializeField] private float sailsRotationSpeed = 10f;
    [SerializeField] private float maxVelocity = 10f;
    private float maxVelocitySquared = 100f;
    private Vector3 wind = Vector3.zero;
    private float timeToWindChange = 0;
    private Rigidbody rb = null;
    private bool isAnchored = false;
    [SerializeField] private Image floodFill = null;
    private float flood = 10f;
    private float floodRate = 0.005f;
    private float floodEmptyRate = 1f;
    private float maxFlood = 100f;
    [SerializeField] private Image fuelFill = null;
    private bool isTurbo = false;
    private float turboBoostSpeed = 5f;
    private float fuel = 100f;
    private float maxFuel = 100f;
    private float fuelUsageRate = 1f;
    private float fuelRegainRate = 0.1f;

    private void Awake()
    {
        this.rb = this.GetComponent<Rigidbody>();
        this.maxVelocitySquared = this.maxVelocity * this.maxVelocity;
    }

    public void RotateSailsClockwise(InputAction.CallbackContext context)
    {
        this.sailsDirection = context.ReadValueAsButton() ? Direction.CLOCKWISE : Direction.NONE; 
    }
    
    public void RotateSailsCounterClockwise(InputAction.CallbackContext context)
    {
        this.sailsDirection = context.ReadValueAsButton() ? Direction.COUNTER_CLOCKWISE : Direction.NONE; 
    }

    public void ToggleAnchor(InputAction.CallbackContext context)
    {
        if (context.started) this.isAnchored = !this.isAnchored;
    }

    public void ToggleBoost(InputAction.CallbackContext context)
    {
        if (context.performed) this.isTurbo = !this.isTurbo;
    }

    public void UseBucket(InputAction.CallbackContext context)
    {
        if (context.started) this.flood = Mathf.Clamp(this.flood - this.floodEmptyRate, 0, this.maxFlood);
    }

    public void FireCannon(InputAction.CallbackContext context)
    {
        
    }
    
    void Update()
    {
        this.ChangeWind();
        this.RotateBoat();
        this.RotateSails();
        this.RotateFlag();
        this.UpdateFill();
    }

    private void FixedUpdate()
    {
        if (this.isAnchored)
        {
            if (this.rb.velocity.sqrMagnitude > 0.01f) this.rb.velocity *= 0.5f * Time.fixedDeltaTime;
            return;
        }

        float speed = Vector3.Dot(this.sails.transform.forward.normalized, this.wind.normalized) * this.maxVelocity;// 0 if perpendicular, 1 if same, -1 if opposite
        // only 25% force if sail is facing wrong direction
        if (speed >= 0) speed *= -0.1f;
        // water penalty
        speed *= (1f - (this.maxFlood / this.flood)) * 0.5f;
        // turbo boost
        if (speed > 0 && this.isTurbo && this.fuel > 0) speed *= this.turboBoostSpeed;

        this.rb.velocity = this.sails.transform.forward * speed;
    }

    private void ChangeWind()
    {
        this.timeToWindChange -= Time.deltaTime;
        if (this.timeToWindChange > 0) return;
        float velocity = Random.Range(2f, 10f);
        float angle = Random.Range(0f, 2 * Mathf.PI);
        Vector2 windDirection = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        windDirection.Normalize();
        this.wind = new Vector3(windDirection.x, 0, windDirection.y) * velocity;
        this.timeToWindChange = Random.Range(300f, 3600f);
    }

    private void RotateBoat()
    {
        Vector3 newDirection = Vector3.RotateTowards(this.body.transform.forward, sails.transform.forward, this.boatRotationSpeed * Time.deltaTime, 0.0f);
        this.body.transform.rotation = Quaternion.LookRotation(newDirection);
    }

    private void RotateSails()
    {
        if (this.sailsDirection != Direction.NONE)
        {
            Vector3 sailsRotation = this.sailsDirection == Direction.CLOCKWISE ? Vector3.up : Vector3.down;
            this.sails.transform.Rotate(sailsRotation * (Time.deltaTime * this.sailsRotationSpeed));
        }
        if (this.boatDirection != Direction.NONE)
        {
            Vector3 boatRotation = this.boatDirection == Direction.CLOCKWISE ? Vector3.up : Vector3.down;
            this.gameObject.transform.Rotate(boatRotation * (Time.deltaTime * this.boatRotationSpeed));
        }
    }

    private void RotateFlag()
    {
        this.flag.transform.LookAt(this.flag.transform.position - this.wind);
    }

    private void UpdateFill()
    {
        this.flood = Mathf.Clamp(this.flood + this.floodRate * Time.deltaTime, 0, this.maxFlood);
        if(this.isTurbo)
            this.fuel = Mathf.Clamp(this.fuel - this.fuelUsageRate * Time.deltaTime, 0, this.maxFuel);
        else
            this.fuel = Mathf.Clamp(this.fuel + this.fuelRegainRate * Time.deltaTime, 0, this.maxFuel);
        this.fuelFill.fillAmount = Mathf.Clamp01(this.fuel / this.maxFuel);
        this.floodFill.fillAmount = Mathf.Clamp01(this.flood / this.maxFlood);
    }
}
