using UnityEngine;
using System.Collections;

public class newlevel : MonoBehaviour {

	// Use this for initialization
	void start () 
	{
			
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "JumpMan")
			Application.LoadLevel("last boss");
	
}
}