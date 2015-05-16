using UnityEngine;
using System.Collections;

public class scriptShootLightP3 : MonoBehaviour {
	
	Transform camera;
	public GameObject lightBullet;
	private bool oneShot = false;
	
	// Use this for initialization
	void Start () {
		camera = transform.GetChild(1);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawLine(camera.position, camera.position + camera.forward,Color.red);
		if(Input.GetAxisRaw("Fire3") == 0.0f)
		{
			oneShot = false;
		}
		if(Input.GetAxisRaw("Fire3") == 0.1f && oneShot == false){
			transform.GetChild(1).GetChild(0).gameObject.animation.Play();
			Instantiate(lightBullet,camera.position + camera.forward,camera.rotation);
			oneShot = true;
			
		}
	}
}
