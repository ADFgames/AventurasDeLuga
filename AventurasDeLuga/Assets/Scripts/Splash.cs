using UnityEngine;
using System.Collections;

[RequireComponent (typeof(AudioSource))]

public class Splash : MonoBehaviour {
	//public string movie;
    // Use this for initialization
	void Start () {
		//Renderer r = GetComponent<Renderer>();
		//MovieTexture movie = (MovieTexture)r.material.mainTexture;

		//RawImage rim = GetComponent<RawImage>();
		//video = (MovieTexture)rim.mainTexture;

    #if UNITY_ANDROID
		//Handheld.PlayFullScreenMovie("Sequence 03_1", Color.black, FullScreenMovieControlMode.CancelOnInput);
		Handheld.PlayFullScreenMovie("Sequence 03_1");
		//Application.LoadLevel("tela_loading");
		//MovieTexture r = GetComponent<Renderer>().material.mainTexture as MovieTexture;
		//GetComponent<AudioSource>().clip = r.audioClip;
		//GetComponent<AudioSource>().Play ();
		//r.Play ();

		//Application.LoadLevel("tela_loading");
	#endif

	#if UNITY_STANDALONE_WIN

        AudioSource audio = GetComponent<AudioSource>();
        //GetComponent<Renderer>().material.mainTexture = video as MovieTexture;
        audio.clip = video.audioClip;
        video.Play();
        audio.Play();
        
    #endif
	}
	
	// Update is called once per frame
	void OnMouseDown()
    {
    #if UNITY_STANDALONE_WIN
        video.Stop();
        Application.LoadLevel("tela_loading");
	#endif
    }


    void Update()
    {
    #if UNITY_STANDALONE_WIN
        if (!video.isPlaying)
        {
            Application.LoadLevel("tela_loading");
        }
	#endif
    }
}
