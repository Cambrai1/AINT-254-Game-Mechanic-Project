using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Need this for calling UI scripts
using UnityEngine.SceneManagement;

namespace ISS
{
    public class Manager : MonoBehaviour
    {

        [SerializeField]
        Transform UIPanel; //Will assign our panel to this variable so we can enable/disable it

        [SerializeField]
        Text timeText; //Will assign our Time Text to this variable so we can modify the text it displays.

        //bool isPaused; //Used to determine paused state

        void Start()
        {
            //UIPanel.gameObject.SetActive(false); //make sure our pause menu is disabled when scene starts
            //isPaused = false; //make sure isPaused is always false when our scene opens
        }
        public void Pause()
        {
            //isPaused = true;
            //UIPanel.gameObject.SetActive(true); //turn on the pause menu
            //Time.timeScale = 0f; //pause the game
        }

        public void UnPause()
        {
            //isPaused = false;
            UIPanel.gameObject.SetActive(false); //turn off pause menu
            //Time.timeScale = 1f; //resume game
            {
                Time.timeScale = 1;
            }
        }

        public void Update()
        {
            //if statement for ESCAPE key press.
            if (Input.GetKeyDown("escape"))
            {

                //pauses the games timeScale between 0 and 1 every time the ESCAPE key is pressed.
                if (Time.timeScale == 1)
                {
                    Time.timeScale = 0;
                    UIPanel.gameObject.SetActive(true);
                }
                else
                {
                    Time.timeScale = 1;
                    UIPanel.gameObject.SetActive(false);
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
            Time.timeScale = 1;
        }
    }
}

