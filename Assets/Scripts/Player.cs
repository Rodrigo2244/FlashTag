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

    private void TestForDamage(GameObject gameObject)
    {
        if(gameObject.tag != "Respawn")
            return;

        health -= damage;

        // Test for death
        if (health <= 0)
            StartCoroutine("ResetPlayer");
    }

    private IEnumerator ResetPlayer()
    {
        //yield return new WaitForSeconds(5.0f);

        lives--;

        if (lives == 0)
            Destroy(gameObject);

        health = 100;
        transform.position = origin;

        yield return null;
    }
}
