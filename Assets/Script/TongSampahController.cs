using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongSampahController : MonoBehaviour {
	//public GameObject ballprefab;
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
	void OnCollisionEnter2D(Collision2D coll)
    {
        // If a missile hits this object
        if (coll.transform.tag == "Respawn")
        {
            Debug.Log("HIT!");
        }
    }
}

/*
1. tong sampah dapat bergerak
2. sampah == tong sampah "skor bertambah"
3. lantai = 5 detik hilang
 */