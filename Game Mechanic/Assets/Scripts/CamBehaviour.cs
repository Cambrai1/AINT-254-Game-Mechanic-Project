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

        [SerializeField]
        private Transform m_camera;

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
            float rotX = m_camera.rotation.eulerAngles.x;

            var distance = Vector3.Distance(m_transform.position, m_player.position);
            
            if (Input.GetKey("left"))
            {
                m_player.rotation = Quaternion.Euler(new Vector3(0.0f, rotY - m_rotationSpeed * Time.deltaTime/2, 0.0f));
            }

            if (Input.GetKey("right"))
            {
                m_player.rotation = Quaternion.Euler(new Vector3(0.0f, rotY + m_rotationSpeed * Time.deltaTime/2, 0.0f));
            }

            if (Input.GetKey("up"))
            {
                m_camera.rotation = Quaternion.Euler(new Vector3(rotX - m_rotationSpeed * Time.deltaTime/2, rotY, 0.0f));
            }

            if (Input.GetKey("down"))
            {
                m_camera.rotation = Quaternion.Euler(new Vector3(rotX + m_rotationSpeed * Time.deltaTime/2, rotY, 0.0f));
            }
        }
    }
}

