using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Wrapping the Ship
/// </summary>
public class ScreenWrapper : MonoBehaviour {

    #region Private memmbers
    private CircleCollider2D circleCollider2D;
    #endregion

    #region Methods

    // Use this for initialization
    private void Start()
    {
        circleCollider2D = GetComponent<CircleCollider2D>();
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
        else if ((circleCollider2D.transform.position.x - circleCollider2D.radius) <= ScreenUtils.ScreenLeft)
        {
            Vector2 pos = transform.position;
            pos.x = ScreenUtils.ScreenRight;
            transform.position = pos;
        }
        else if ((circleCollider2D.transform.position.y - circleCollider2D.radius) > ScreenUtils.ScreenTop)
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
