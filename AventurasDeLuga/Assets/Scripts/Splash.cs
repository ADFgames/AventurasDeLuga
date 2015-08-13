using UnityEngine;
using System.Collections;

public class splash : MonoBehaviour {
	public float pass = 1f;
	// Use this for initialization
	void Start () {
		Cursor.visible = false;
		StartCoroutine ("Espera");
	}

	IEnumerator Espera(){
		yield return new WaitForSeconds (5.5f);
		Cursor.visible = true;
		Application.LoadLevel (1);
	}
}
