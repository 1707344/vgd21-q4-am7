using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float attackDamage = 10f;
    [SerializeField] private float attackSpeed = 1f;
    private float canAttack;


    private void OnTriggerStay2D(Collider2D collision)
    {
        //Jim is leaving here for trigger, if needed.
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("======================" + other.gameObject.name);
            if (attackSpeed <= canAttack)
            {
                other.gameObject.GetComponent<PlayerHealth>().UpdateHealth(-attackDamage);
                canAttack = 0f;
                
            }
            else
            {
                canAttack += Time.deltaTime;
            }
        }

    }

}
