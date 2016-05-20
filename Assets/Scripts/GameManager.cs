using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

	public int score;
	public Text	scoreDisplay;
	public Text playerName;
	
	

	void Start () {
		
		scoreDisplay = GameObject.Find ("score").GetComponent<Text> ();
		playerName = GameObject.Find ("playerName").GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		scoreDisplay.text = "Score:" + score.ToString ();
		
	}
	
	public void AddPlayerName(string name){
		
		playerName.text = name;
		Application.LoadLevel("JumpMan");
		
	}
	
}