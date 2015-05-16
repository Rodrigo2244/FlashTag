using UnityEngine;
using System.Collections;

public class scriptShootLight : MonoBehaviour {

	Transform camera;
	public GameObject lightBullet;

	// Use this for initialization
	void Start () {
		camera = transform.GetChild(1);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawLine(camera.position, camera.position + camera.forward,Color.red);

		if(Input.GetMouseButtonDown(0)){
			Instantiate(lightBullet,camera.position + camera.forward,camera.rotation);
		}
	}
}
