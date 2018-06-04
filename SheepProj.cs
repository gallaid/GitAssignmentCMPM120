using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepProj : MonoBehaviour {

    public GameObject brain;
    void Start()
    {

        brain = GameObject.FindGameObjectWithTag("Brain");
    }
    void Update()
    {

        // transform.Translate(transform.TransformDirection(brain.transform.position) * Time.deltaTime,Space.Self);
        transform.position = Vector3.MoveTowards(transform.position, brain.transform.position, 1 * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == ("Brain"))
        {

            Destroy(gameObject);


        }
    }
}
