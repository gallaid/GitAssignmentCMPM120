using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {

    public GameObject brain;

    SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        //Do some stuff here
        brain = GameObject.FindGameObjectWithTag("Brin");


    }

    // Update is called once per frame
    void Update()
    {

        // transform.Translate(transform.TransformDirection(brain.transform.position) * Time.deltaTime,Space.Self);
        transform.position = Vector3.MoveTowards(transform.position, brain.transform.position, 1.5f * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == ("Brin"))
        {
            
            
            Destroy(gameObject);


        }

    }
}
