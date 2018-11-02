using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Ship Configurations
/// </summary>
public class Ship : MonoBehaviour {

    #region Fields
    Rigidbody2D rigidbody2;
    Vector2 thrustDirection ;
    #endregion
    
    #region Constants
    const float ThrustForce = 1;
    #endregion

    #region Methods
    // Use this for initialization
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
        thrustDirection = new Vector2(1, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Used to apply Force to RigidBody
    private void FixedUpdate()
    {
        if (Input.GetAxis("Thrust") > 0)
        {
            rigidbody2.AddForce(thrustDirection * ThrustForce,ForceMode2D.Force);

        }
    }
    #endregion
}
