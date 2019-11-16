using UnityEngine;
using System.Collections;

public class SpawnMonstersController : MonoBehaviour {

    public GameObject monster1;
    public GameObject monster2;
    public float interval = 3;


	// Use this for initialization
	void Start () {
        InvokeRepeating("spawnMonster", interval, interval);
	}
	
    void spawnMonster()
    {
        float v = Random.value;

        if (v < .20)
        {
            GameObject g = (GameObject)Instantiate(monster1, transform.position, Quaternion.identity);
        }else if(v < 0.40)
        {
            GameObject g = (GameObject)Instantiate(monster2, transform.position, Quaternion.identity);
        }


    }


}
