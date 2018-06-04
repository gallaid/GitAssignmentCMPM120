using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brain : MonoBehaviour {
    public int health;
	// Use this for initialization
	void Start () {
        
        transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 10));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void takeDamage(int damage)
    {
        health -= damage;
        //print(health + " in brain");
        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(7);
        }
    }
}
