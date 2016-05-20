using UnityEngine;
using System.Collections;

public class hope : MonoBehaviour {

	public float			speed = 4f;
	public float			jumpSpeed = 10f;
	public bool				onFloor = false;
	public bool				walking = false;
	public GameObject		bullet;
	public static bool		left = true;
	

	

	void Start () {
	
		
	}
	

	void Update () {
		float xAxis = Input.GetAxis("Horizontal");

		
		Vector2 pos = transform.position;
		pos.x += xAxis * speed;
		

		
		if(Mathf.Abs(Input.GetAxis("Horizontal")) >= .05f){
			if(Input.GetAxis("Horizontal") > 0){
				transform.localScale = new Vector2(-3, 3);
				left = true;
			} else {
				transform.localScale = new Vector2(3, 3);
				left = false;
			}
			walking = true;
		} else {
			walking = false;
		}
		


		
		if(onFloor && Input.GetButtonDown("Jump")){
			GetComponent<Rigidbody2D>().velocity = new Vector2(

				GetComponent<Rigidbody2D>().velocity.x, 

				jumpSpeed
				);

		}
		transform.position = pos;

	
	
	}
}