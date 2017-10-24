using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamCanvasScript : MonoBehaviour {

    public int currentHeight;
    public int bestHeight;
	// Use this for initialization
	void Start () {
        currentHeight = 10;
        bestHeight = 10;
	}
    [SerializeField]
    private Text m_text;
	void Update () {

        if (currentHeight >= bestHeight)
        {
            bestHeight = currentHeight;

        }

       m_text.text = ("Best Height:" + bestHeight.ToString() + "\nCurrent Height:" + currentHeight.ToString());
    }
}
