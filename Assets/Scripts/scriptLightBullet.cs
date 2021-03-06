﻿using UnityEngine;
using System.Collections;

public class scriptLightBullet : MonoBehaviour {

	public AudioClip bounce;

	// Use this for initialization
	void Start () {
		rigidbody.AddForce(transform.forward*1500);
		StartCoroutine(Die ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		AudioSource.PlayClipAtPoint(bounce,transform.position);
	}

	IEnumerator Die(){
		yield return new WaitForSeconds(10);
		Destroy(this.gameObject);
	}
}
