using UnityEngine;
using System.Collections;

public class scriptGameManager : MonoBehaviour {

	public int playerNum = 2;
	private bool setPlayers;
	private GameObject playerActivate;
	private GameObject playerCam;
	private Camera playerCamSet;

	void Start(){
		DontDestroyOnLoad(this.gameObject);
	}

	void OnLevelWasLoaded(int level){
		if(level == 1 && setPlayers == false){
			if(playerNum == 2)
			{	//P1
				playerCam = GameObject.Find("P1Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0, 0.5f, 1, 0.5f);
				//P2
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
				playerCam = GameObject.Find("P1Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0, 0.5f, 0.5f, 0.5f);
				
				playerCam = GameObject.Find("P2Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0.5f , 0.5f, 0.5f, 0.5f);
				
				playerCam = GameObject.Find("P3Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0 , 0, 1, 0.5f);

				playerActivate = GameObject.Find ("Player4");
				playerActivate.SetActive(false);

			}
			else if(playerNum == 4)
			{
				playerCam = GameObject.Find("P1Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0, 0.5f, 0.5f, 0.5f);
				
				playerCam = GameObject.Find("P2Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0.5f , 0.5f, 0.5f, 0.5f);
				
				playerCam = GameObject.Find("P3Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0 , 0, 0.5f, 0.5f);

				playerCam = GameObject.Find("P4Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0.5f , 0, 0.5f, 0.5f);

			}

		}
	}
}