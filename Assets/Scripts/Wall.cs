using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour 
{
    private MeshRenderer meshRenderer;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter(Collision other)
    {
        ChangeColor(other.gameObject);
    }

	private void ChangeColor(GameObject gameObject)
    {
        if (gameObject.GetComponent<scriptLightBullet>() == null)
            return;

        meshRenderer.enabled = true;

        Light light = gameObject.GetComponent<Light>();

        meshRenderer.material.color = light.color;
    }
}
