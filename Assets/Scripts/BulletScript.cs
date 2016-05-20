using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	public float		speed = 2f;

	// Use this for initialization
	void Awake() {

		if(guyScript.left) speed = speed;
		else speed = -speed;
			

		GetComponent<Rigidbody2D>().velocity = new Vector2(Time.deltaTime * speed, 0);

	}

	
}
