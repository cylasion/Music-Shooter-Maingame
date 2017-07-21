using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIScript : MonoBehaviour {

	public Text _ComboText, _ScoreText;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_ComboText.text ="Combo : "+ Score.getCombo ().ToString();
		_ScoreText.text = "Score : "+Score.getScore ().ToString ();
	}
}
