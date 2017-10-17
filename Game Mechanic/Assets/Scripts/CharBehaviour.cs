using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

namespace ISS
{
    public class CharBehaviour : MonoBehaviour
    {
        [SerializeField]
        private float m_speed = 10.0f;

        [SerializeField]
        private Slider slider;

        [SerializeField]
        private Image image;

        private Transform m_transform;
        public Rigidbody rb;
        public float speed = 10.0f;
        public int moveSpeed = 10;
        public float downTime, upTime, power;
        public float minJump = 10;
        public float maxJump = 20;
        
        Vector3 down = new Vector3(0, -1, 0);

        void Start()
        {
            m_transform = GetComponent<Transform>();
            rb = GetComponent<Rigidbody>();
        }

        
        // Update is called once per frame
        void Update()
        {

            

            image.enabled = !(slider.value == 10);

            if (Input.GetKey("w"))
            {
                m_transform.position += m_transform.forward * m_speed * Time.deltaTime;
            }

            if (Input.GetKey("s"))
            {
                m_transform.position -= m_transform.forward * m_speed * Time.deltaTime;
            }

            if (Input.GetKey("a"))
            {
                m_transform.position -= m_transform.right * m_speed * Time.deltaTime;
            }

            if (Input.GetKey("d"))
            {
                m_transform.position += m_transform.right * m_speed * Time.deltaTime;
            }

            if (Input.GetKeyDown("space"))
            {
                downTime = Time.time;
            }

            if (Input.GetKey("space"))
            {
                upTime = Time.time;
                power = (((upTime - downTime) * 10) + minJump);
                slider.value = power;
            }

            if (Input.GetKeyUp("space"))
            {             
                Debug.DrawRay(transform.position, down, Color.red, 5);

                if (Physics.Raycast(transform.position, down, 2))
                {
                    rb.velocity = new Vector3(rb.velocity.x, (power > maxJump) ? maxJump : power, rb.velocity.z);

                    Debug.Log(power);

                    slider.value = 10;
                }
            }
        }

        void OnCollisionEnter(Collision Sphere)
        {
            if (Sphere.gameObject.tag == "Sphere")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            
        }
    }
}       


        
         





