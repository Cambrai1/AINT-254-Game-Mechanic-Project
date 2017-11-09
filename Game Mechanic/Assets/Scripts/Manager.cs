using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace ISS
{
    public class Manager : MonoBehaviour
    {
        public Button RestartButton;

        public float Restartbool = 1.0f;

        [SerializeField]
        Transform UIPanel;

        [SerializeField]
        Text timeText;

        void Start()
        {
           
        }

        public void Pause()
        {
            UIPanel.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

        public void UnPause()
        {
            UIPanel.gameObject.SetActive(false);
            Time.timeScale = 1;
            Restartbool = 0;
        }

        public void Update()
        {
            if (Input.GetKeyDown("escape"))
            {
                if (Time.timeScale == 0)
                {
                    UnPause();
                }
                else
                {
                    Pause();
                }
            }

            if (Restartbool == 1.0f)
            {
                RestartButton.interactable = false;
            }

            else
            {
                RestartButton.interactable = true;
            }

        }
        public void QuitGame()
        {
            Application.Quit();
        }

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            UnPause();
            Restartbool = 1;
        }
    }
}

