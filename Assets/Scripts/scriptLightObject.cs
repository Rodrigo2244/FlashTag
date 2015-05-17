using UnityEngine;
using System.Collections;

public class scriptLightObject : MonoBehaviour {

	public bool invisibility = true;
	public bool invisible = true;

	void OnCollisionEnter(Collision col){
		if(invisibility){
			if(col.gameObject.tag == "Respawn" && invisible){
				invisible = false;
				Debug.Log("hit");
				light.enabled = true;
				light.color = col.gameObject.light.color;
				renderer.enabled = true;
				renderer.material.color = col.gameObject.light.color;
				StartCoroutine(Diminish());
			}
		}
	}

	IEnumerator Diminish(){
		animation.Play("LightObject");
		yield return new WaitForSeconds(10f);
		light.enabled = false;
		renderer.enabled = false;
		invisible = true;
	}
}