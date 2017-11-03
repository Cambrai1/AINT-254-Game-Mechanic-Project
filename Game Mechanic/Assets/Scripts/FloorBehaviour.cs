using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ISS
{
    public class FloorBehaviour : MonoBehaviour
    {

        public GameObject SpherePre;

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
                Destroy(Sphere.gameObject);
                SpawnSphere();
            }

        }

        private void SpawnSphere()
        {
            if (GameObject.Find("Character").GetComponent<CharBehaviour>().heightY < 30)
            {
                Vector3 newPos = new Vector3(Random.Range(-26, 29), 100, Random.Range(-28, 60));
                GameObject octo = Instantiate(SpherePre, newPos, Quaternion.identity) as GameObject;
            }

            else if (GameObject.Find("Character").GetComponent<CharBehaviour>().heightY >= 30 && GameObject.Find("Character").GetComponent<CharBehaviour>().heightY <= 110)
            {
                Vector3 newPos = new Vector3(Random.Range(-130, 29), 125, Random.Range(-59, -37));
                GameObject octo = Instantiate(SpherePre, newPos, Quaternion.identity) as GameObject;
            }

            if (GameObject.Find("Character").GetComponent<CharBehaviour>().heightY > 80)
            {
                Vector3 newPos = new Vector3(Random.Range(-143, -38), 165, Random.Range(5, 80));
                GameObject octo = Instantiate(SpherePre, newPos, Quaternion.identity) as GameObject;
            }
        }
    }
}

