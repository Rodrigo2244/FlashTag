using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scriptMainMenu : MonoBehaviour {

	Text playerNumDisplay;
	scriptGameManager gameManager;

	void Start(){
		playerNumDisplay = GameObject.Find("Player Num").transform.GetChild(0).GetComponent<Text>();
		gameManager = GameObject.Find("_Game Manager").GetComponent<scriptGameManager>();
	}

	void Update(){
		playerNumDisplay.text = gameManager.playerNum.ToString();
	}

	void Play(){
		Application.LoadLevel("Practice");
	}

	void Exit(){
		Application.Quit();
	}

	void ChangePlayerNum(){
		if(gameManager.playerNum != 4){
			gameManager.playerNum++;
		} else {
			gameManager.playerNum = 2;
		}
	}
}