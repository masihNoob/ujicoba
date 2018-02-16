using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongSampahController : MonoBehaviour {

	public float speed = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)){
			//kiri
			GoLeft();
		}else if(Input.GetKey(KeyCode.D)){
			//kanan
			GoRight();
		}
	}

	private void GoLeft(){
		transform.Translate(Vector3.left * speed* Time.deltaTime);
	}
	private void GoRight(){
		transform.Translate(Vector3.right * speed* Time.deltaTime);
	}
}

/*
1. tong sampah dapat bergerak
2. sampah == tong sampah "skor bertambah"
3. lantai = 5 detik hilang
 */