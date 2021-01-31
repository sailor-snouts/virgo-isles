using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{
    public enum Direction {NONE, CLOCKWISE, COUNTER_CLOCKWISE}

    private Direction sailsDirection = Direction.NONE;
    private Direction boatDirection = Direction.NONE;
    [SerializeField] private GameObject sails = null;
    [SerializeField] private GameObject flag = null;
    [SerializeField] private float boatRotationSpeed = 10f;
    [SerializeField] private float sailsRotationSpeed = 10f;
    [SerializeField] private float maxVelocity = 10f;
    private float maxVelocitySquared = 100f;
    private Vector3 wind = Vector3.zero;
    private float timeToWindChange = 0;
    private Rigidbody rb = null;

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
        this.ChangeWind();
        this.RotateSails();
        this.RotateFlag();
    }

    private void FixedUpdate()
    {
        float speed = Vector3.Dot(this.sails.transform.forward.normalized, this.wind.normalized) * this.maxVelocity;// 0 if perpendicular, 1 if same, -1 if opposite
        if (speed <= 0) speed *= -0.25f;// only 25% force if sail is facing wrong direction
        this.rb.velocity = this.sails.transform.forward * speed;
    }

    private void ChangeWind()
    {
        this.timeToWindChange -= Time.deltaTime;
        if (this.timeToWindChange > 0) return;
        float velocity = Random.Range(0f, 10f);
        float angle = Random.Range(0f, 2 * Mathf.PI);
        Vector2 windDirection = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        windDirection.Normalize();
        this.wind = new Vector3(windDirection.x, 0, windDirection.y) * velocity;
        this.timeToWindChange = Random.Range(300f, 3600f);
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
}
