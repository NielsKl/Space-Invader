using UnityEngine;
using System.Collections;

public class CollisionPlayerWithEnemyController : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D c)
    {

        if(c.gameObject.tag == "Monster")
        {
            Destroy(gameObject);
            Destroy(c.gameObject);
        }


    }
}
