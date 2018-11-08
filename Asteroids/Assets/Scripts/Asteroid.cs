using UnityEngine;

/// <summary>
/// Configure Asteroids (Ships)
/// </summary>
public class Asteroid : MonoBehaviour
{
    #region Private memmbers
    private float forceMagnitude;
    private float forceDirectionRange;
    private Vector2 forceDirection;
    #endregion

    #region Serialized memmbers
    [SerializeField]
    private Sprite[] shipsSprites;
    #endregion

    #region Methods

    // Use this for initialization
    private void Start()
    {
        #region Moving the Ship
        // Create random force variable
        forceMagnitude = Random.Range(1, 5);

        // Create random direction from 0 to 2 pi
        forceDirectionRange = Random.Range(0, Mathf.Deg2Rad * 360);

        // Craete Vector2 to hold the direction
        forceDirection = new Vector2(Mathf.Cos(forceDirectionRange), Mathf.Sin(forceDirectionRange));

        // Adding inpulse force with random force and radom direction
        transform.GetComponent<Rigidbody2D>().AddForce((forceMagnitude * forceDirection), ForceMode2D.Impulse);
        #endregion

        // Select Random Sprite for the Ship
        gameObject.GetComponent<SpriteRenderer>().sprite = shipsSprites[Random.Range(0, shipsSprites.Length)];
    }
    #endregion
}
