using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ISS
{
    public class FloorBehaviour : MonoBehaviour
    {

        public GameObject SpherePre;
        public GameObject SpherePreSmall;
        private Transform m_transform;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnCollisionEnter(Collision Sphere)
        {
            if (Sphere.gameObject.tag == "Sphere")
            {
                //Destroy(Sphere.gameObject);
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
            if (GameObject.Find("Character").GetComponent<CharBehaviour>().heightY > 0)
            {
                Destroy(Sphere.gameObject);
            }
        }

        private void SpawnSphere()
        {

            if (GameObject.Find("Character").GetComponent<CharBehaviour>().heightY < 45)
            {
                Vector3 newPos = new Vector3(Random.Range(75, 116), 25, Random.Range(-235, -268));
                GameObject octo = Instantiate(SpherePreSmall, newPos, Quaternion.identity) as GameObject;
            }

            else if (GameObject.Find("Character").GetComponent<CharBehaviour>().heightY >= 45 && GameObject.Find("Character").GetComponent<CharBehaviour>().heightY <= 110)
            {
                Vector3 newPos = new Vector3(Random.Range(-130, 29), 125, Random.Range(-59, -37));
                GameObject octo = Instantiate(SpherePreSmall, newPos, Quaternion.identity) as GameObject;
            }

            if (GameObject.Find("Character").GetComponent<CharBehaviour>().heightY > 80)
            {
                
                if (Random.Range(0f, 1f) > 0.5f)
                {
                    Vector3 newPos = new Vector3(Random.Range(-143, -38), 165, Random.Range(5, 80));
                    GameObject octo = Instantiate(SpherePre, newPos, Quaternion.identity) as GameObject;
                    Debug.Log("Red");
                }

                else
                {
                    Vector3 newPos = new Vector3(Random.Range(-143, -38), 165, Random.Range(5, 80));
                    GameObject octo = Instantiate(SpherePreSmall, newPos, Quaternion.identity) as GameObject;
                    Debug.Log("Blue");
                }

            }
        }
    }
}

