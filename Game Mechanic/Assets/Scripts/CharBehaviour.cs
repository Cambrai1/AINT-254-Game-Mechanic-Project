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
        public float downTime, upTime, power;


        Vector3 down = new Vector3(0, -1, 0);

        void Start()
        {
            m_transform = GetComponent<Transform>();
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            //if (rb.velocity.y < -2 && grounded == false)
            //{
            //    grounded = true;
            //}


            float rotY = m_transform.rotation.eulerAngles.y;

            m_transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotY + m_rotationSpeed *
                Input.GetAxis("Horizontal") * Time.deltaTime, 0.0f));

            m_transform.position += m_transform.forward * m_speed * Input.GetAxis("Vertical") * Time.deltaTime;

            if (Input.GetKeyDown("space"))
            {
                downTime = Time.time;
            }



            if (Input.GetKeyUp("space"))
            {
                upTime = Time.time;
                power = ((upTime - downTime) * 6);

                Debug.DrawRay(transform.position, down, Color.red, 5);
                if (Physics.Raycast(transform.position, down, 2))
                {

                    rb.velocity = new Vector3(rb.velocity.x, power, rb.velocity.z);

                    Debug.Log(Time.time);

                }

            }

            
        }
    }
}       


        
         





