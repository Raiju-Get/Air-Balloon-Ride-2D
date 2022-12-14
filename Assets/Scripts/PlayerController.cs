using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private BalloonController balloonController;
    [SerializeField] private Rigidbody2D playPhysic2D;
    [SerializeField] private float jumpForce;
    [SerializeField] private float maxVelocity;
    [SerializeField] private float sqrMaxVelocity;
    [SerializeField] private Animator _animator;

    private void Awake()
    {
        SetMaxVelocity(maxVelocity);
    }
    

    void SetMaxVelocity(float maxVelocity)
    {
        this.maxVelocity = maxVelocity;
        sqrMaxVelocity = maxVelocity * maxVelocity;
    }
    
    private void FixedUpdate()
    {
        var velocity = playPhysic2D.velocity;
        if (velocity.sqrMagnitude>sqrMaxVelocity)
        {
            playPhysic2D.velocity = velocity.normalized * maxVelocity;
        }
    }
    public void FlightController()
    {
        balloonController.BalloonFloat(playPhysic2D,jumpForce);
        balloonController.SquishBallon(_animator);
    }

    public void StopPlayerVelocity()
    {
        playPhysic2D.velocity = Vector2.zero;
        
    }


}
