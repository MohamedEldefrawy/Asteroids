using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Configure Asteroids
/// </summary>
public class Asteroid : MonoBehaviour {

    private float forceMagnitude = 1;
    private float forceDirectionRange;
    private Vector2 forceDirection;
	// Use this for initialization
	void Start () {
        forceMagnitude = Random.Range(1, 5);
        forceDirectionRange = Random.Range(0, Mathf.Deg2Rad * 360);
        forceDirection = new Vector2(Mathf.Cos(forceDirectionRange), Mathf.Sin(forceDirectionRange));
        transform.GetComponent<Rigidbody2D>().AddForce((forceMagnitude*forceDirection),ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
