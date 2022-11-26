using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float yMin;
    [SerializeField] private float yMax;
    [SerializeField] private float yValue;
    

    private void Start()
    {
       
    }

    private void Update()
    {
        yValue = Mathf.Clamp(player.position.y,yMin,yMax);
        transform.position = new Vector3(transform.position.x, yValue, transform.position.z);
    }
}
