using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingScript : MonoBehaviour
{
    public float health;
    SpriteRenderer sprite;

    public bool canTakeDamage = true;
    public void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();


    }
    public void Update()
    {
    }

    public void Hit(float damage)
    {
        health -= canTakeDamage ? damage : 0;
        if (health <= 0)
        {
            Die();
            return;
        }
        print("HIT");
        canTakeDamage = false;
        StartCoroutine("Flash");
    }

    public IEnumerator Flash()
    {

        sprite.color = new Color(sprite.color.r * 2, sprite.color.g / 2, sprite.color.b / 2, 1f);
        yield return new WaitForSeconds(0.1f);
        sprite.color = new Color(sprite.color.r / 2, sprite.color.g * 2, sprite.color.b * 2, 1f);
        yield return new WaitForSeconds(0.7f);
        canTakeDamage = true;
    }


    public void Die()
    {
        Destroy(gameObject);
    }
}
