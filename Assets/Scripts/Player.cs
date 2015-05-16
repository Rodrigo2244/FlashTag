using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
    public int ammo;
    public int health;
    public int damage;
    public int lives;

    private Vector3 origin;

    void Awake()
    {
        health = 100;
        damage = 50;
        lives = 2;

        origin = transform.position;
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

        if (health <= 0)
            StartCoroutine("ResetPlayer");
    }

    private IEnumerator ResetPlayer()
    {
        lives--;

        if (lives == 0)
        {
            Destroy(gameObject);
            yield return null;
        }

        health = 100;
        transform.position = origin;
    }
}
