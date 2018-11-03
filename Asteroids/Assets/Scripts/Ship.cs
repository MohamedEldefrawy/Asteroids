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
    CircleCollider2D circleCollider2D;
    #endregion
    
    #region Constants
    const float ThrustForce = 1;
    #endregion

    #region Methods

    // Use this for initialization
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
        circleCollider2D = GetComponent<CircleCollider2D>();
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

    // Wrap Ship When getting out of camera boundries
    private void OnBecameInvisible()
    {
        if ((circleCollider2D.transform.position.x - circleCollider2D.radius) >= ScreenUtils.ScreenRight)
        {
            Vector2 pos = transform.position;
            pos.x = ScreenUtils.ScreenLeft;
            transform.position = pos;
        }
        else if((circleCollider2D.transform.position.x - circleCollider2D.radius) <= ScreenUtils.ScreenLeft)
        {
            Vector2 pos = transform.position;
            pos.x = ScreenUtils.ScreenRight;
            transform.position = pos;
        }
        else if((circleCollider2D.transform.position.y - circleCollider2D.radius) > ScreenUtils.ScreenTop)
        {
            Vector2 pos = transform.position;
            pos.y = ScreenUtils.ScreenBottom;
            transform.position = pos;
        }
        else if ((circleCollider2D.transform.position.y - circleCollider2D.radius) < ScreenUtils.ScreenBottom)
        {
            Vector2 pos = transform.position;
            pos.y = ScreenUtils.ScreenTop;
            transform.position = pos;
        }
    }
    #endregion
}
