﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBehaviour : MonoBehaviour {

    public GameObject SpherePre;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnCollisionEnter(Collision Sphere)
    {
        if (Sphere.gameObject.tag == "Sphere")
        {
            Destroy(Sphere.gameObject);
            SpawnSphere();
            //Instantiate(Sphere, 0.0.0 , Quaternion.identity);
        }

    }

    private void SpawnSphere()
    {
        Vector3 newPos = new Vector3(Random.Range(-26, 29), 100, Random.Range(-28, 60));
        GameObject octo = Instantiate(SpherePre, newPos, Quaternion.identity) as GameObject;
    }
}