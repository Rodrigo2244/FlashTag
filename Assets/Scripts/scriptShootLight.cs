﻿using UnityEngine;
using System.Collections;

public class scriptShootLight : MonoBehaviour {

	Transform camera;
	public GameObject lightBullet;
	private bool oneShot = false;

	void Start () {
		camera = transform.GetChild(1);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawLine(camera.position, camera.position + camera.forward,Color.red);
		if(Input.GetAxisRaw("Fire1") == 0.0f)
		{
			oneShot = false;
		}
		if(Input.GetAxisRaw("Fire1") == 0.1f && oneShot == false){
			transform.GetChild(1).GetChild(0).gameObject.animation.Play();
			Instantiate(lightBullet,camera.position + camera.forward,camera.rotation);
			oneShot = true;

		}
	}
}
