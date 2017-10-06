using UnityEngine;
using System.Collections;

namespace ISS
{
    public class CharBehaviour : MonoBehaviour
    {
        [SerializeField]
        private float m_speed = 10.0f;

        [SerializeField]
        private float m_rotationSpeed = 50.0f;

        private Transform m_transform;
        public Rigidbody rb;
        public float speed = 10.0f;
        public int moveSpeed = 10;
        // Use this for initialization

        void Start()
        {
            m_transform = GetComponent<Transform>();
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            
            float rotY = m_transform.rotation.eulerAngles.y;

            m_transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotY + m_rotationSpeed * 
                Input.GetAxis("Horizontal") * Time.deltaTime, 0.0f));

           m_transform.position += m_transform.forward * m_speed * Input.GetAxis("Vertical") * Time.deltaTime;

            if (Input.GetKeyDown("space"))
                rb.velocity = new Vector3(rb.velocity.x, 10, rb.velocity.z);

            //if (Input.GetKeyDown("w"))
            //rb.velocity = new Vector3(5, rb.velocity.y, rb.velocity.z);
            //if (Input.GetKey(KeyCode.W))
            //{
                //transform.position += (Vector3.forward * moveSpeed * Time.deltaTime);
            //}
            //if (Input.GetKey(KeyCode.S))
           //{
                //transform.position += (Vector3.back * moveSpeed * Time.deltaTime);
          //}
            //if (Input.GetKeyDown("a"))
                //rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 5);

            //if (Input.GetKeyDown("d"))
               // rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -5);

        }
   
    }

}

