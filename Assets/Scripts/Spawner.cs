using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour{
	public GameObject[] layouts;
	public Quaternion[] rotations;

	void Start(){
		rotations = new Quaternion[4]{new Quaternion(0,0,0,0),new Quaternion(0,90,0,0),new Quaternion(0,180,0,0),new Quaternion(0,270,0,0)};

		Instantiate(layouts[Random.Range(0,layouts.Length)],new Vector3(0,0,0),rotations[Random.Range(0,rotations.Length)]);
		Instantiate(layouts[Random.Range(0,layouts.Length)],new Vector3(0,0,24),rotations[Random.Range(0,rotations.Length)]);
		Instantiate(layouts[Random.Range(0,layouts.Length)],new Vector3(-24,0,0),rotations[Random.Range(0,rotations.Length)]);
		Instantiate(layouts[Random.Range(0,layouts.Length)],new Vector3(-24,0,24),rotations[Random.Range(0,rotations.Length)]);

		Instantiate(layouts[Random.Range(0,layouts.Length)],new Vector3(0,8.44f,0),new Quaternion(180,rotations[Random.Range(0,rotations.Length)].y,0,0));
		Instantiate(layouts[Random.Range(0,layouts.Length)],new Vector3(0,8.44f,24),new Quaternion(180,rotations[Random.Range(0,rotations.Length)].y,0,0));
		Instantiate(layouts[Random.Range(0,layouts.Length)],new Vector3(-24,8.44f,0),new Quaternion(180,rotations[Random.Range(0,rotations.Length)].y,0,0));
		Instantiate(layouts[Random.Range(0,layouts.Length)],new Vector3(-24,8.44f,24),new Quaternion(180,rotations[Random.Range(0,rotations.Length)].y,0,0));
	}
}