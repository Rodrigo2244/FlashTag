using UnityEngine;
using System.Collections;

public class scriptLightBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody.AddForce(transform.forward*500);
		StartCoroutine(Die ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Die(){
		yield return new WaitForSeconds(10);
		Destroy(this.gameObject);
	}
}
