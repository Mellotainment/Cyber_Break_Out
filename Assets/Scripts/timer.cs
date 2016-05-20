using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {


		
	public float speed = 5f; 
	public float countdown = 10.0f;
		
		
	void Start(){
	}

		void Update ()
		{
			countdown -= Time.deltaTime;
			if(countdown <= 0.0f)
				Application.LoadLevel("you won");
	}

	}
