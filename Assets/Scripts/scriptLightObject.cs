using UnityEngine;
using System.Collections;

public class scriptLightObject : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if(col.gameObject.name == "Light Bullet"){
			Debug.Log("hit");
			light.enabled = true;
			renderer.enabled = true;
		}
	}
}