using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ISS
{
    public class CamCanvasScript : MonoBehaviour
    {

        private static float currentHeight;
        private static float bestHeight;
        // Use this for initialization
        void Start()
        {

        }
        [SerializeField]
        private Text m_text;

        [SerializeField]
        private Rigidbody rb;

        void Update()
        {
            currentHeight = GameObject.Find("Character").GetComponent<CharBehaviour>().heightY;

            if (currentHeight >= bestHeight)
            {
                bestHeight = currentHeight;

            }

            m_text.text = ("Best Height:" + bestHeight.ToString("0.00") + "\nCurrent Height:" + currentHeight.ToString("0.00"));
        }
    }
}

