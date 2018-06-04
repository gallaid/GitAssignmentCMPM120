using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

    public GameObject brain;
    public float speed;
    public float ranNumber;
    public float direction;
    public bool clockWise;
	// Use this for initialization
	void Start () {
        clockWise = false;
        if (Random.Range(0, 100)%2==0)
        {
            clockWise = true;
        }
        if (clockWise)
        {
            direction = -1;
        }
        else
        {
            direction = 1;
        }
        brain = GameObject.FindGameObjectWithTag("Brain");
        
        Vector3 spawnPos = new Vector3(brain.transform.position.x + Random.Range(3f, 5), brain.transform.position.y + Random.Range(-5f, 3));
        transform.position = spawnPos;
	}
	
	// Update is called once per frame
	void Update () {
        OrbitAround();
	}
    void OrbitAround()
    {
        transform.RotateAround(brain.transform.position, Vector3.forward*direction, speed * Time.deltaTime);
    }
}
