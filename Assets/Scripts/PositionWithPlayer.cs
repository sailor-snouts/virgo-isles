using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionWithPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    
    private void Update()
    {
        Vector3 position = this.transform.position;
        position.x = this.player.position.x;
        position.z = this.player.position.z;
        this.transform.position = position;
    }
}
