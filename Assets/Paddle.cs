using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Paddle : MonoBehaviour {
	public Text points;
	private AudioSource audio;

	// Use this for initialization
	void Start () {
		GameStatus.points = 0;
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlePosition = new Vector3 (0.5f ,this.transform.position.y,0);
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		
		paddlePosition.x = Mathf.Clamp (mousePosInBlocks,0.5f, 15.5f);
		
		this.transform.position = paddlePosition;
	}

	void OnCollisionEnter2D (Collision2D collision) {
		Debug.Log ("Collision detected");
		GameStatus.points++;
		audio.Play ();

		points.text = GameStatus.points + " hits";

		if (GameStatus.points == GameStatus.maxHits) {
			Application.LoadLevel("Win");
		}

	}
}
