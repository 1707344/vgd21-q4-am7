using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    ParticleSystem part;
    // Start is called before the first frame update
    void Start()
    {
        part = gameObject.GetComponent<ParticleSystem>();
        part.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnParticleCollision(GameObject other)
    {

        if(other.GetComponent<Collider2D>() == null)
        {
            return;
        }

        Collider2D collider = other.GetComponent<Collider2D>();

        if (collider.CompareTag("Enemy"))
        {
            collider.GetComponent<EnemyHealth>().Hit(1);
        }
    }
}
