using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.rigidbody2D.velocity = new Vector2 (2f, 10f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D (Collision2D collision) {
		audio.Play ();	
	}
}
