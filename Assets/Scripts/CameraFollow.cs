using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject		player;
	public Light			spotlight;
	public float			speed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log(player.transform.position.x);

/*
		transform.position = new Vector3(
			player.transform.position.x, 
			player.transform.position.y,
			-10f);
*/

		Vector3 target = new Vector3(
				player.transform.position.x,
				player.transform.position.y,
				-10f);

		Vector3 lightTarget = new Vector3(
				player.transform.position.x,
				player.transform.position.y,
				-20f);

		transform.position = Vector3.Slerp(  // or Vector3.Lerp();
				this.transform.position, 
				target, 
				Time.deltaTime * speed);

		spotlight.transform.position = Vector3.Slerp(  // or Vector3.Lerp();
				spotlight.transform.position, 
				lightTarget, 
				Time.deltaTime * speed);

		if(Input.GetKeyDown("a")){
			spotlight.enabled = false;
		}

		if(Input.GetKeyDown("z")){
			spotlight.enabled = true;
		}

		// if(player.transform.position.x > this.transform.position.x + 1f){
		
		// 	transform.position = Vector3.Lerp(
		// 		this.transform.position, 
		// 		target, 
		// 		Time.deltaTime);
		// }
	
	}
}
