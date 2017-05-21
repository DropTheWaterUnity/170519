using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotFloat : MonoBehaviour {

	float delta = 0.002f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// Gclef Move y+=delta per frame
		float newYPosition = transform.position.y + delta;
		transform.position = new Vector3(0, newYPosition, 0);

		// Round trip
		if (transform.position.y < 0.7){
			delta = 0.002f;
		} 
		else if (transform.position.y > 0.9){
			delta = -0.002f;
		}

	}
}
