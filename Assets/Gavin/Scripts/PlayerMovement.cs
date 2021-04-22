using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 speed;

    public bool isAttacking;
    bool canAttack = true;
    GameObject playerHand;
    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        playerHand = transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed.x, Input.GetAxis("Vertical") * speed.y);

        if(rb.velocity.x > 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }else if(rb.velocity.x < 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * -1, transform.localScale.y, transform.localScale.z);
        }

        isAttacking = (Input.GetKeyDown(KeyCode.K) && canAttack) || isAttacking;


        if (isAttacking)
        {
            playerHand.transform.position = Vector2.Lerp(playerHand.transform.position, transform.GetChild(3).position, 0.1f);
            canAttack = false;
            Invoke("TurnAttackOff", 0.1f);
        }
        else
        {
            playerHand.transform.position = Vector2.Lerp(playerHand.transform.position, transform.GetChild(2).position, 0.1f);
            Invoke("TurnCanAttackOn", 0.15f);
        }
    }

    void TurnAttackOff()
    {
        isAttacking = false;
    }

    void TurnCanAttackOn()
    {
        canAttack = true;
    }
}
