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
			{	print ("YOOO");
				playerCam = GameObject.Find("P1Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0, 0, 0.5f, 0.5f);

				playerCam = GameObject.Find("P2Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0.5f , 0.5f, 0.5f, 1);
			}
			else if(playerNum == 3)
			{


			}
			else if(playerNum == 4)
			{


			}

		}
	}
}