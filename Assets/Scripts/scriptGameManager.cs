using UnityEngine;
using System.Collections;

public class scriptGameManager : MonoBehaviour {

	public int playerNum = 2;
	private bool gameStart = false;
	private GameObject playerActivate;
	private GameObject playerCam;
	private Camera playerCamSet;
	private Vector3 player1Spawn;
	private Vector3 player2Spawn;
	private Vector3 player3Spawn;
	private Vector3 player4Spawn;

	void Start(){
		DontDestroyOnLoad(this.gameObject);
	}

	void OnLevelWasLoaded(int level){
		if(level == 1){
			if(playerNum == 2)
			{	//P1
				playerActivate = GameObject.Find("Player1");
				player1Spawn = playerActivate.transform.position;
				playerCam = GameObject.Find("P1Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0, 0.5f, 1, 0.5f);
				//P2
				playerActivate = GameObject.Find("Player2");
				player2Spawn = playerActivate.transform.position;
				playerCam = GameObject.Find("P2Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0 , 0, 1, 0.5f);
				//P3
				playerActivate = GameObject.Find ("Player3");
				playerActivate.SetActive(false);
				//P4
				playerActivate = GameObject.Find ("Player4");
				playerActivate.SetActive(false);
			}
			else if(playerNum == 3)
			{
				playerActivate = GameObject.Find("Player1");
				player1Spawn = playerActivate.transform.position;
				playerCam = GameObject.Find("P1Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0, 0.5f, 0.5f, 0.5f);

				playerActivate = GameObject.Find("Player2");
				player2Spawn = playerActivate.transform.position;
				playerCam = GameObject.Find("P2Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0.5f , 0.5f, 0.5f, 0.5f);

				playerActivate = GameObject.Find("Player3");
				player3Spawn = playerActivate.transform.position;
				playerCam = GameObject.Find("P3Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0 , 0, 1, 0.5f);

				playerActivate = GameObject.Find ("Player4");
				playerActivate.SetActive(false);

			}
			else if(playerNum == 4)
			{
				playerActivate = GameObject.Find("Player1");
				player1Spawn = playerActivate.transform.position;
				playerCam = GameObject.Find("P1Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0, 0.5f, 0.5f, 0.5f);

				playerActivate = GameObject.Find("Player2");
				player2Spawn = playerActivate.transform.position;
				playerCam = GameObject.Find("P2Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0.5f , 0.5f, 0.5f, 0.5f);

				playerActivate = GameObject.Find("Player3");
				player3Spawn = playerActivate.transform.position;
				playerCam = GameObject.Find("P3Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0 , 0, 0.5f, 0.5f);

				playerActivate = GameObject.Find("Player4");
				player4Spawn = playerActivate.transform.position;
				playerCam = GameObject.Find("P4Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0.5f , 0, 0.5f, 0.5f);

			}
		
			gameStart = true;
		}
	}

	void Update(){

	}
}