using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    int doDamage;
   public GameObject brain;
    public List<Sprite> pics;
    SpriteRenderer spriteRenderer;
    
	// Use this for initialization
	void Start () {
        doDamage = 5;
        brain = GameObject.FindGameObjectWithTag("Brain");
        spriteRenderer=GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = pics[Random.Range(0, pics.Count - 1)];
        
	}
	
	// Update is called once per frame
	void Update () {

        // transform.Translate(transform.TransformDirection(brain.transform.position) * Time.deltaTime,Space.Self);
        transform.position = Vector3.MoveTowards(transform.position, brain.transform.position, 1*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == ("Brain"))
        {
            Brain brain = other.gameObject.GetComponent<Brain>();
            brain.takeDamage(doDamage);
            Destroy(gameObject);


        }
    }
}
