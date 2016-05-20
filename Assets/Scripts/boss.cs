using UnityEngine;
using System.Collections;

public class boss : MonoBehaviour {

	public float	enemySpeed = 1f;
	public int 		dir = 1;
	public float	offset = -1;
	
	
	void Start () {
		
	}
	
	
	void Update () {
		
		float t = Time.time - offset;
		
		
		
		if(t > 5){
			dir = -dir;
			offset = Time.time;
		}
		
		
		
		
		GetComponent<Rigidbody2D>().velocity = new Vector2(
			
			enemySpeed * dir, 
			
			GetComponent<Rigidbody2D>().velocity.x
			);
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "black")
			Application.LoadLevel("end");
	}
	
}
	

	

			
		
	
