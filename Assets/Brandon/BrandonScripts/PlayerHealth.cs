using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    SpriteRenderer sprite;
    public float health = 0f;
    [SerializeField] private float maxHealth = 100f;

    public bool canTakeDamage = true;

    private void Start()
    {
        health = maxHealth;
        sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    public void UpdateHealth(float mod)
    {
        health += mod;
        if (mod < 0)
        {
            Hit(mod);
        }

        if (health > maxHealth)
        {
            health = maxHealth;
        } else if(health <= 0f)
        {
            health = 0f;
            Debug.Log("Player Respawn");
        }
    }

    public void Hit(float damage)
    {
        health -= canTakeDamage ? damage : 0;
        if (health <= 0)
        {
            Die();
            return;
        }
        print("*******************************HIT");
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

        //Destroy(gameObject);
        gameObject.SetActive(false);
    }
}
