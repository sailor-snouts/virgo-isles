using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Island : MonoBehaviour
{
    private bool hasGrown = false;
    private Animation animation = null;
    
    public void Awake()
    {
        this.animation = this.GetComponent<Animation>();
    }

    public void Grow()
    {
        this.animation.Play();
        this.hasGrown = true;
        FindObjectOfType<PlayerController>().ProgressCheck();// i know this is the worst but im short on time
    }

    public bool HasGrown()
    {
        return this.hasGrown;
    }
}
