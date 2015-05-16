using UnityEngine;
using System.Collections;

public class scriptLightObject : MonoBehaviour {
	
	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Respawn"){
			Debug.Log("hit");
			light.enabled = true;
			light.color = col.gameObject.light.color;
			renderer.enabled = true;
			renderer.material.color = col.gameObject.light.color;
			StartCoroutine(Diminish());
		}
	}

	IEnumerator Diminish(){
		animation.Play("LightObject");
		yield return new WaitForSeconds(10f);
		light.enabled = false;
		renderer.enabled = false;
	}
}