using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public int charge;
    public int HowManyToWin;

    public SheepMaker makesheep;
    // Use this for initialization
    void Start () {
        //  GameObject brain = GameObject.FindGameObjectWithTag("Brain");
        // Vector3 spawnPos = new Vector3(brain.transform.position.x +1, brain.transform.position.y+1);
        //  transform.position = spawnPos;


        makesheep = GetComponentInParent<SheepMaker>();

        
       
        

    }
	
	// Update is called once per frame
	void Update () {
        if (charge >= HowManyToWin)
        {
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextSceneIndex);
        }
       // print(MakeSheep);

       
	}
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Projectile")
        {
            charge += 1;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Sheep")
        {
            makesheep.MakeSheep();
            
            Destroy(other.gameObject);

        }
        if (other.gameObject.tag == "Clock")
        {
            GetComponentInParent<OrbitPlayerControl>().increaseSpeed();
            Destroy(other.gameObject);
        }

    }






}
