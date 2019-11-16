using UnityEngine;
using System.Collections;

public class BorderCollision : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag != "Player")
        {
            Destroy(c.gameObject);
        }
    }

}
