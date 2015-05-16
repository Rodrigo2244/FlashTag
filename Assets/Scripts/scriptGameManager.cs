using UnityEngine;
using System.Collections;

public class scriptGameManager : MonoBehaviour {

	public int playerNum = 2;

	void Start(){
		DontDestroyOnLoad(this.gameObject);
	}
}
