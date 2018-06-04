using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepMaker : MonoBehaviour {
    List<GameObject> slots;

	// Use this for initialization
	void Start () {
        slots = new List<GameObject>();
        slots.Add(GameObject.Find("spot1"));
        slots.Add(GameObject.Find("spot2"));
        slots.Add(GameObject.Find("spot3"));
        slots.Add(GameObject.Find("spot4"));
        slots.Add(GameObject.Find("spot5"));
        slots.Add(GameObject.Find("spot6"));
        slots.Add(GameObject.Find("spot7"));

        foreach (GameObject sheep in slots)
        {
            sheep.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void MakeSheep()
    {
        int ranNumb = Random.Range(0, 6);
  

        for(int i=0;i<7;i++)
        {
            if (!slots[ranNumb].activeSelf)
            {
                slots[ranNumb].SetActive(true);
                i = 10;
            }
            else
            {
                if (ranNumb == 6)
                {
                    ranNumb = 0;
                }
                else
                {
                    ranNumb += 1;
                }
            }
        }
    }
}
