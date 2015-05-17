using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scriptGameManager : MonoBehaviour {

	public int playerNum = 2;
	private bool gameStart = false;
	private GameObject playerActivate;
	private GameObject playerCam;
	private Camera playerCamSet;
	private GameObject[] players;
	public int deadPlayers = 0;
	public bool stalactites;
	public bool invisibility;
	private Text playerWin;


	void Start(){
		DontDestroyOnLoad(this.gameObject);
	}

	void OnLevelWasLoaded(int level){
		if(level == 1){
			if(playerNum == 2)
			{	//P1
				playerActivate = GameObject.Find("Player1");

				playerCam = GameObject.Find("P1Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0, 0.5f, 1, 0.5f);
				//P2
				playerActivate = GameObject.Find("Player2");

				playerCam = GameObject.Find("P2Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0 , 0, 1, 0.5f);
				//P3
				playerActivate = GameObject.Find ("Player3");
				playerActivate.SetActive(false);
				//P4
				playerActivate = GameObject.Find ("Player4");
				playerActivate.SetActive(false);

				players = GameObject.FindGameObjectsWithTag("Player");
			}
			else if(playerNum == 3)
			{
				playerActivate = GameObject.Find("Player1");

				playerCam = GameObject.Find("P1Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0, 0.5f, 0.5f, 0.5f);

				playerActivate = GameObject.Find("Player2");

				playerCam = GameObject.Find("P2Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0.5f , 0.5f, 0.5f, 0.5f);

				playerActivate = GameObject.Find("Player3");

				playerCam = GameObject.Find("P3Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0 , 0, 1, 0.5f);

				playerActivate = GameObject.Find ("Player4");
				playerActivate.SetActive(false);

				players = GameObject.FindGameObjectsWithTag("Player");

			}
			else if(playerNum == 4)
			{
				playerActivate = GameObject.Find("Player1");

				playerCam = GameObject.Find("P1Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0, 0.5f, 0.5f, 0.5f);

				playerActivate = GameObject.Find("Player2");

				playerCam = GameObject.Find("P2Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0.5f , 0.5f, 0.5f, 0.5f);

				playerActivate = GameObject.Find("Player3");

				playerCam = GameObject.Find("P3Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0 , 0, 0.5f, 0.5f);

				playerActivate = GameObject.Find("Player4");

				playerCam = GameObject.Find("P4Cam");
				playerCamSet = playerCam.GetComponent<Camera>();
				playerCamSet.rect = new Rect(0.5f , 0, 0.5f, 0.5f);

				players = GameObject.FindGameObjectsWithTag("Player");

			}
		
			gameStart = true;
			print (players.Length);
		}
	}

	void Update()
	{

	}

	public void GameOver()
	{
		deadPlayers++;

		if(deadPlayers == playerNum - 1)
		{
			StartCoroutine("DeathDelay");
			StartCoroutine("BackToMainMenu");
		}

	}

	private IEnumerator DeathDelay()
	{
		yield return new WaitForSeconds(0.1f);
		for(int i = 0 ; i < players.Length; i++)
		{
			if(players[i] != null)
			{
				print(players[i].name + " WINS");
			}
			
		}
			print(players.Length);
		
	}

	private IEnumerator BackToMainMenu()
	{
		yield return new WaitForSeconds(5f);
		Destroy(this.gameObject);
		Application.LoadLevel("Main Menu");
	}
}