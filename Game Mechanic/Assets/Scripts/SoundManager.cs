using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour {

    [SerializeField]
    private AudioMixerSnapshot m_Gamemode;

    [SerializeField]
    private AudioMixerSnapshot m_Menumode;

    public void Menumode()
    {
        m_Menumode.TransitionTo(0.5f);
    }

    public void Gamemode()
    {
        m_Gamemode.TransitionTo(0.5f);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
