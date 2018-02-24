using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour {
    public float delay = 0;
	private void Start() {
		StartCoroutine(desLantai());
	}

	IEnumerator desLantai(){
		
		yield return new WaitForSeconds(delay);
        Destroy(this.gameObject);
	}
	private void OnCollisionEnter2D(Collision2D other) {
		switch (other.gameObject.tag)
		{
			
			case "Player":
			Destroy(this.gameObject);
//			Debug.Log("test");
			ScoreScr.scorVal +=1;
			break;

			case "Lantai":
			desLantai();
			break;
		}
	}
}
