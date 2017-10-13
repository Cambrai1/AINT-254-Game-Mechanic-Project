using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ISS
{
    public class CamBehaviour : MonoBehaviour
    {

        [SerializeField]
        private float m_speed = 10.0f;

        // Use this for initialization
        void Start()
        {
            m_transform = GetComponent<Transform>();
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKey("up"))
            {
                m_transform.position -= m_transform.forward * m_speed * Time.deltaTime;
            }
        }
    }
}

