using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ISS
{
    public class SphereBehaviour : MonoBehaviour
    {
        public Transform Character;
        public float speed = 1.0f;
        private Vector3 directionOfCharacter;
        private bool challenged = false;

        void Update()
        {
            if (challenged)
            {
                directionOfCharacter = Character.transform.position - transform.position;
                directionOfCharacter = directionOfCharacter.normalized;
                transform.Translate(directionOfCharacter * speed, Space.World);
            }

            if (GameObject.Find("Character").GetComponent<CharBehaviour>().heightY > 115)
            {
                challenged = true;
            }

            if (Time.timeScale == 0)
            {
                speed = 0.0f;
            }

            if (Time.timeScale == 1)
            {
                speed = 0.2f;
            }
        }




    }

}
