using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scriptMainMenu : MonoBehaviour {

	Text playerNumDisplay;
	Text stalactitesDisplay;
	scriptGameManager gameManager;

	void Start(){
		playerNumDisplay = GameObject.Find("Player Num").transform.GetChild(0).GetComponent<Text>();
		stalactitesDisplay = GameObject.Find("Stalactites").transform.GetChild(0).GetComponent<Text>();
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

	void Stalactite(){
		gameManager.stalactites = !gameManager.stalactites;

		if(gameManager.stalactites){
			stalactitesDisplay.text = "On";
		} else {
			stalactitesDisplay.text = "Off";
		}
	}

	void ChangePlayerNum(){
		if(gameManager.playerNum != 4){
			gameManager.playerNum++;
		} else {
			gameManager.playerNum = 2;
		}
	}
}