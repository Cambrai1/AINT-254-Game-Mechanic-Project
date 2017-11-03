using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Group : MonoBehaviour
{
    private CanvasGroup m_group;

    // Use this for initialization
    void Start()
    {
        m_group = GetComponent<CanvasGroup>();
        Time.timeScale = 0;
        //m_group.alpha = 0;
    }

    [SerializeField]
    private AudioMixer m_mixer;

    [SerializeField]
    private SoundManager m_SoundManager;

    public void SetAmbientVolume(float _volume)
    {
        m_mixer.SetFloat("AmbientVolume", _volume);
    }
	
	// Update is called once per frame
	void Update ()
    {
	    //if(Input.GetKeyDown(KeyCode.Escape))
     //   {
     //       if(m_group.alpha == 0)
     //       {
     //           m_group.alpha = 1;
     //           //m_SoundManager.Menumode();
     //       }
     //       else
     //       {
     //           m_group.alpha = 0;
     //           //m_SoundManager.Gamemode();
     //       }
     //   }
	}
}
