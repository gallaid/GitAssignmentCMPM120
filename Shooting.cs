using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public bool canShoot;
    public GameObject thought;
    public GameObject SheepProj;
    public GameObject Clock;


    // Use this for initialization
    void Start()
    {
        canShoot = false;
        StartCoroutine(shotTimer(Random.Range(3f, 6.5f)));
    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot)
        {
            canShoot = false;

            StartCoroutine(shotTimer(Random.Range(1f, 6.5f)));
        }
    }

    private IEnumerator shotTimer(float time)
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y);
        if (Random.Range(0, 100) < 25)
        {
            if (Random.Range(0, 100) < 10)
            {
                GameObject projectile = Instantiate(Clock, pos, transform.rotation);
            }
            else
            {
                GameObject projectile = Instantiate(SheepProj, pos, transform.rotation);
            }

        }
        else
        {
            GameObject projectile = Instantiate(thought, pos, transform.rotation);
        }

        //projectile.transform.position = transform.position + transform.forward * 1.5f;
        yield return new WaitForSeconds(time);
        canShoot = true;
    }


}
