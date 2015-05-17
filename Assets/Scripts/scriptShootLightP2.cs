using UnityEngine;
using System.Collections;

public class scriptShootLightP2 : MonoBehaviour {
	
	Transform camera;
	public GameObject lightBullet;
	private bool oneShot = false;
	public AudioClip shoot;
	private float shotTimer = 0.0f;

	void Start () {
		camera = transform.GetChild(1);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawLine(camera.position, camera.position + camera.forward,Color.red);

		if(Input.GetAxisRaw("Fire2") == 0.1f && shotTimer == 0){
			transform.GetChild(1).GetChild(0).gameObject.animation.Play();
			Instantiate(lightBullet,camera.position + camera.forward,camera.rotation);
			oneShot = true;
			AudioSource.PlayClipAtPoint(shoot,transform.position);
			shotTimer = 1.0f;
		}
		shotTimer -= Time.deltaTime;
		if(shotTimer < 0.0f)
		{
			shotTimer = 0.0f;
		}
	}
}
