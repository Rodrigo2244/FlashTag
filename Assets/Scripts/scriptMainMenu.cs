using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scriptMainMenu : MonoBehaviour {

	Text playerNumDisplay;
	Text stalactitesDisplay;
	Text invisibleDisplay;
	scriptGameManager gameManager;
	public AudioClip submit;

	void Start(){
		Screen.showCursor = false;

		playerNumDisplay = GameObject.Find("Player Num").transform.GetChild(0).GetComponent<Text>();
		stalactitesDisplay = GameObject.Find("Stalactites").transform.GetChild(0).GetComponent<Text>();
		invisibleDisplay = GameObject.Find("Invisibility").transform.GetChild(0).GetComponent<Text>();
		gameManager = GameObject.Find("_Game Manager").GetComponent<scriptGameManager>();
	}

	void Update(){
		playerNumDisplay.text = "Players: " + gameManager.playerNum.ToString();
	}

	void Play(){
		AudioSource.PlayClipAtPoint(submit,transform.position);
		Application.LoadLevel("Practice");
	}

	void Exit(){
		AudioSource.PlayClipAtPoint(submit,transform.position);
		Application.Quit();
	}

	void Stalactite(){
		AudioSource.PlayClipAtPoint(submit,transform.position);

		gameManager.stalactites = !gameManager.stalactites;

		if(gameManager.stalactites){
			stalactitesDisplay.text = "Stalactites: On";
		} else {
			stalactitesDisplay.text = "Stalactites: Off";
		}
	}

	void Invisiblity(){
		AudioSource.PlayClipAtPoint(submit,transform.position);

		gameManager.invisibility = !gameManager.invisibility;
		
		if(gameManager.invisibility){
			invisibleDisplay.text = "Invisibility: On";
		} else {
			invisibleDisplay.text = "Invisibility: Off";
		}
	}

	void ChangePlayerNum(){

		AudioSource.PlayClipAtPoint(submit,transform.position);

		if(gameManager.playerNum != 4){
			gameManager.playerNum++;
		} else {
			gameManager.playerNum = 2;
		}
	}
}