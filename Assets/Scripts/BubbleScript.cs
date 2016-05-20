using UnityEngine;
using System.Collections;

public class BubbleScript : MonoBehaviour {
	public Vector3 		target = new Vector3(1, 1, 1);
	public float		someNumber = .05f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = Vector3.Lerp(
			transform.localScale,
			target,
			Time.deltaTime * someNumber);
	
	}
}
