using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ISS
{
    public class FloorBehaviour : MonoBehaviour
    {

        public GameObject SpherePre;
        public GameObject SpherePreSmall;
        public GameObject SphereNew;
        private Transform m_transform;
        public float heightY;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            heightY = transform.position.y;
        }

        void OnCollisionEnter(Collision Sphere)
        {
            if (Sphere.gameObject.tag == "Sphere")
            {
                Destroy(Sphere.gameObject);
                SpawnSphere();
                Sphere.gameObject.tag = "NotSphere";

                if (GameObject.Find("Character").GetComponent<CharBehaviour>().heightY > 0)
                {
                    //SpawnSphere();
                }

            }

        }

        void OnCollisionStay(Collision Sphere)
        {
            if (GameObject.Find("Character").GetComponent<CharBehaviour>().heightY < 0)
            {
                Destroy(Sphere.gameObject);
            }
        }

        private void SpawnSphere()
        {

            if (GameObject.Find("Character").GetComponent<CharBehaviour>().heightY < 20)
            {
                Vector3 newPos = new Vector3(Random.Range(75, 116), 25, Random.Range(-235, -268));
                GameObject octo = Instantiate(SpherePreSmall, newPos, Quaternion.identity) as GameObject;
            }

            else if (GameObject.Find("Character").GetComponent<CharBehaviour>().heightY >= 20 && GameObject.Find("Character").GetComponent<CharBehaviour>().heightY <= 75)
            {
                Vector3 newPos = new Vector3(Random.Range(-30, 2), 50, Random.Range(-200, -260));
                GameObject octo = Instantiate(SpherePreSmall, newPos, Quaternion.identity) as GameObject;
            }

            if ((GameObject.Find("Character").GetComponent<CharBehaviour>().heightY > 75) && (GameObject.Find("Character").GetComponent<CharBehaviour>().heightY < 120))
            {
                Vector3 newPos = new Vector3(Random.Range(-120, -85), 125, Random.Range(-195, -165));
                GameObject octo = Instantiate(SphereNew, newPos, Quaternion.identity) as GameObject;
                Debug.Log("Red");
            }

            if ((GameObject.Find("Character").GetComponent<CharBehaviour>().heightY > 75) && (GameObject.Find("Character").GetComponent<CharBehaviour>().heightY < 170))
            {
                Vector3 newPos = new Vector3(Random.Range(-200, -90), 220, Random.Range(-210, -380));
                GameObject octo = Instantiate(SphereNew, newPos, Quaternion.identity) as GameObject;
            }

            if ((GameObject.Find("Character").GetComponent<CharBehaviour>().heightY > 120) && (GameObject.Find("Character").GetComponent<CharBehaviour>().heightY < 170))
            {
                Vector3 newPos = new Vector3(Random.Range(-200, -90), 220, Random.Range(-210, -380));
                GameObject octo = Instantiate(SphereNew, newPos, Quaternion.identity) as GameObject;
            }
        }
    }
}


