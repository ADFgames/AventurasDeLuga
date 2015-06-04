using UnityEngine;
using System.Collections;

public class ReprodutorVideo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Handheld.PlayFullScreenMovie("SPLASH_MP4.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
