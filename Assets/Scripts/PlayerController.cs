using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private BalloonController balloonController;
    [SerializeField] private Rigidbody2D playPhysic2D;
    [SerializeField] private float jumpForce;

    public void FlightController()
    {
        balloonController.BalloonFloat(playPhysic2D,jumpForce);
    }

    public void StopPlayerVelocity()
    {
        playPhysic2D.velocity = Vector2.zero;
        
    }

}
