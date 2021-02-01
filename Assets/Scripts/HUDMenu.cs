using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDMenu : MonoBehaviour
{
    [SerializeField] private Image minimap = null;
    [SerializeField] private Image playerIcon = null;
    [SerializeField] private Transform player = null;

    private void Update()
    {
        Vector3 position = new Vector3(this.player.position.x * -0.1f, 900f - this.player.position.z * 0.1f, this.minimap.transform.position.z);
        this.minimap.rectTransform.anchoredPosition = position;
        
        Vector3 rotation = player.eulerAngles;
        rotation.x = 0;
        rotation.z = 360 - rotation.y;
        rotation.y = 0;
        this.playerIcon.transform.rotation = Quaternion.Euler(rotation);
    }
}
