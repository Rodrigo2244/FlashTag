using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour 
{
    private float rate = Time.deltaTime * 10.0f;

	void Update () 
    {
        transform.Rotate(Vector3.right * rate);
	}
}
