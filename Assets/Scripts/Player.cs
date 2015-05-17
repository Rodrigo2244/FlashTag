using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
    public int health;
    public int damage;
    public int lives;
    public GameObject weapon;

    private Vector3 origin;
    private Color originalColor;
    private Material weaponMaterial;

    void Awake()
    {
        health = 100;
        damage = 50;
        lives = 2;

        origin = transform.position;
//        weaponMaterial = weapon.GetComponent<MeshRenderer>().materials[2];
    }

    void Start()
    {
//        originalColor = weaponMaterial.color;
//        StartCoroutine("WeaponBlink");
    }

    void OnCollisionEnter(Collision other)
    {
        TestForDamage(other.gameObject);
    }

    private void TestForDamage(GameObject otherGameObject)
    {
        if(otherGameObject.tag != "Respawn")
            return;

        Destroy(otherGameObject);

        health -= damage;

        StartCoroutine("AnimatePointLight");

        if (health <= 0)
            StartCoroutine("ResetPlayer");
    }

    private IEnumerator ResetPlayer()
    {
        lives--;

        if (lives == 0)
            Destroy(gameObject);
            
        health = 100;
        transform.position = origin;

        yield return null;
    }

    private IEnumerator AnimatePointLight()
    {
        light.enabled = true;
		animation.Play("LightObject");

		yield return new WaitForSeconds(10f);

		light.enabled = false;
	}

    /*private IEnumerator WeaponBlink()
    {
        for (int i = 0; i < 5; i++)
        {
            // This is not working - GG Andrew
            weaponMaterial.color = Color.white;
            yield return new WaitForSeconds(0.5f);
            weaponMaterial.color = originalColor;

        }
    }*/
}

