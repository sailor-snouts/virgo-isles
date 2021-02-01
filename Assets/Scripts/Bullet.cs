using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    
    private Rigidbody rb = null;

    private void OnEnable()
    {
        this.rb = this.GetComponent<Rigidbody>();
        this.rb.velocity = this.transform.up * this.speed;
    }

    private void Update()
    {
        if(this.transform.position.y < -20)
            Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Island")) return;
        Animation animation = other.gameObject.GetComponent<Animation>();
        animation.Play();
    }
}
