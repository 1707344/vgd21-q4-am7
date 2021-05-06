using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 speed;

    public bool isAttacking;
    SpriteRenderer sprite;
    ParticleSystem particleSystem;

    // Start is called before the first frame update
    void Start()
    {
        particleSystem = transform.GetChild(1).GetComponent<ParticleSystem>();
        sprite = gameObject.GetComponent<SpriteRenderer>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed.x, Input.GetAxis("Vertical") * speed.y);

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float angle = Mathf.Atan((mousePosition.y - transform.position.y) / (mousePosition.x - transform.position.x)) * Mathf.Rad2Deg;
        if(mousePosition.x - transform.position.x < 0)
        {
            angle += 180;
        }
        
        particleSystem.transform.rotation = Quaternion.Euler(0, 0, angle);

        if (rb.velocity.x > 0)
        {
            //particleSystem.transform.localScale = new Vector3(1, 1, 1);
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }else if(rb.velocity.x < 0)
        {
            //particleSystem.transform.localScale = new Vector3(-1, 1, 1);
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * -1, transform.localScale.y, transform.localScale.z);
        }

        if (Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            particleSystem.Play();
        }
    }

}
