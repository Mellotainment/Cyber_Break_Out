using UnityEngine;
using System.Collections;

public class scoreScript : MonoBehaviour {

	public int 			score;
	public int 		highScore;

	public string		playerName;

	// Use this for initialization
	void Start () {
		score = 0;
		
		highScore = PlayerPrefs.GetInt("highScore");

	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown("space")){
			score += 1;
		}

		if(score > highScore){
			PlayerPrefs.SetInt("highScore", score);
		}



		Debug.Log(score + " : " + highScore);

	}
}
