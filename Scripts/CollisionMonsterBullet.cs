using UnityEngine;
using System.Collections;

public class CollisionMonsterBullet : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Monster" || c.gameObject.tag == "Bullet")
        {
            Physics2D.IgnoreCollision(c.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            Destroy(gameObject);

            if (c.gameObject.tag != "Wall")
            {
                Destroy(c.gameObject);
            }
        }
    }

}
