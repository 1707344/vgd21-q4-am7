using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControls : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 20f;
    private Rigidbody2D rb;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    //Update is called once per frame
    private void Update()
    {
        if(transform.position.y < -2.5)
        {
            moveCharacter(Vector2.up);
        }
        else
        {
            Vector2 direction = player.position - transform.position;
            direction.Normalize();
            movement = direction;
            movement.y = 0;
            //print(movement);
            moveCharacter(movement);
            followPlayer();
        }
        
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
        
        //transform.position = new Vector3(transform.position.x + direction.x * moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
    }

    void followPlayer()
    {
        if (transform.position.x < player.position.x)
        {
            //Moving to the right
            transform.localScale = new Vector2(-1, 1);
        }
        else
        {
            //Moving to the left
            transform.localScale = new Vector2(1, 1);
        }
    }




}
    

