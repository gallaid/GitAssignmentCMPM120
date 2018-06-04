using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitPlayerControl : MonoBehaviour {

    public GameObject brain;
    public float speed;


    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal")!=0){
        OrbitAround(Input.GetAxis("Horizontal"));
        }
        
    }
    void OrbitAround(float direction)
    {
       // print(brain.transform.position);
        
        transform.RotateAround(brain.transform.position, Vector3.back*direction, speed * Time.deltaTime);
    }

public void increaseSpeed()
    {
        StartCoroutine(SpeedNess());
    }

    private IEnumerator SpeedNess()
    {
        float oldSpeed = speed;
        speed *= 2f;
        yield return new WaitForSeconds(2f);
        speed = oldSpeed;
    }
}
