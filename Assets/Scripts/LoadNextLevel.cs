using UnityEngine;
using System.Collections;

public class LoadNextLevel : MonoBehaviour {

	// Use this for initialization
	void Awake () 
	{
		Debug.Log ("First Scene Loaded");	
	}
	
	// Update is called once per frame
	void Update () {
			
		if (Input.GetKeyDown ("enter")) {
				Application.LoadLevel("JumpMan");
		}
	}
}