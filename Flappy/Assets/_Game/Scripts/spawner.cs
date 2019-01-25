using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public GameObject target;

    public float nextWallSpawnTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Time.time > nextWallSpawnTime)
        {
            nextWallSpawnTime = Time.time+4;
            
            GameObject wall = Instantiate(target);
            Vector3 wallpossssition = wall.transform.position;
            wallpossssition.x = 10;
            wallpossssition.y = Random.Range(-3,3);
            wall.transform.position = wallpossssition;


        }


	}
}
