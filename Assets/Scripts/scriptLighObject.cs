﻿using UnityEngine;
using System.Collections;

public class scriptLighObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Respawn"){
			Debug.Log("hit");
			light.enabled = true;
		}
	}
}
