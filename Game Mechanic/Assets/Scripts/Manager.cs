using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace ISS
{
    public class Manager : MonoBehaviour
    {

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
        }
        public void QuitGame()
        {
            Application.Quit();
        }

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            UnPause();
        }
    }
}

