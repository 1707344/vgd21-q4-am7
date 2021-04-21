using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    public SpriteRenderer sprite;

    public void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Hit(2);
        }
    }

    public void Hit(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
            return;
        }


    }

    public void Flash()
    {
        
    }

    public void Die()
    {

    }
}
