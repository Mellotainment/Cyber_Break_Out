using UnityEngine;
using System.Collections;

public class guyScript : MonoBehaviour {

	public float			speed = 7f;
	public float			jumpSpeed = 10f;
	public bool				onFloor = false;
	public bool				walking = false;
	public GameObject		bullet;
	public static bool		left = true;
	
	public Animator			guyAnimator;
	
	// Use this for initialization
	void Start () {
		guyAnimator = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		float xAxis = Input.GetAxis("Horizontal");
		//Debug.Log(Input.GetAxis("Horizontal"));
		
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
				// x value
				GetComponent<Rigidbody2D>().velocity.x, 
				// y value
				jumpSpeed
				);

		}
		transform.position = pos;
		
		if(walking){
			guyAnimator.SetInteger("animState", 1);
		} else {
			guyAnimator.SetInteger("animState", 0);
		}
		
		
	}
	
	void OnCollisionStay2D(){
		onFloor = true;
	}
	
	void OnCollisionExit2D(){
		onFloor = false;

	}
	

	
	
	
	
}
