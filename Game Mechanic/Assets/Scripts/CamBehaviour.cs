using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ISS
{
    public class CamBehaviour : MonoBehaviour
    {

        [SerializeField]
        private float m_speed = 3.0f;

        [SerializeField]
        private float m_rotationSpeed = 100.0f;

        [SerializeField]
        private Transform m_player;

        private Transform m_transform;
        public Rigidbody rb;

        // Use this for initialization
        void Start()
        {
            m_transform = GetComponent<Transform>();
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            float rotY = m_player.rotation.eulerAngles.y;
            Debug.Log(m_transform.localPosition.z);

            if (Input.GetKey("down") && (m_transform.position.z > -5))
            {
                    m_transform.localPosition -= m_transform.forward * m_speed * Time.deltaTime;
            }

            if (Input.GetKey("up") && (m_transform.position.z < 0))
            {
                m_transform.localPosition += m_transform.forward * m_speed * Time.deltaTime;
            }

            if (Input.GetKey("left"))
            {
                m_player.rotation = Quaternion.Euler(new Vector3(0.0f, rotY + m_rotationSpeed * Time.deltaTime, 0.0f));
            }

            if (Input.GetKey("right"))
            {
                m_player.rotation = Quaternion.Euler(new Vector3(0.0f, rotY - m_rotationSpeed * Time.deltaTime, 0.0f));
            }
        }
    }
}

