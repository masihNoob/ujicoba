using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScr : MonoBehaviour {
	public static int scorVal =0;
	Text scoreObj;
	// Use this for initialization
	void Start () {
		scoreObj = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		scoreObj.text = "score :" + scorVal;
	}
}
