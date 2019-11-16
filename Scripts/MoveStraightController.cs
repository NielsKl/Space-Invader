using UnityEngine;
using System.Collections;

public class MoveStraightController : MonoBehaviour {

    public Vector2 velocity;

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
    }


}
