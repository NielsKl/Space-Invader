using UnityEngine;
using System.Collections;

public class PlayerMovementController : MonoBehaviour {

    public float speed = 10;

    void FixedUpdate()
    {

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 dir = new Vector2(h, v);
        GetComponent<Rigidbody2D>().velocity = dir.normalized * speed;

        GetComponent<Animator>().SetBool("isFlyingUp", (v > 0));
        GetComponent<Animator>().SetBool("isFlyingLeft", (h < 0));
        GetComponent<Animator>().SetBool("isFlyingRight", (h > 0));

    }



}
