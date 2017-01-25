using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private AudioSource audio;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        audio = GetComponent<AudioSource>();
        audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D (Collision2D collision) {
		audio.Play ();	
	}
}
