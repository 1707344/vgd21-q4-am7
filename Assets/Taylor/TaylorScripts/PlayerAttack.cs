using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Transform enemy;
    private float dist;
    public float howclose;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy").transform;
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(enemy.position, transform.position);

        if (Input.GetKeyDown("k") && dist <= howclose)
        {
            Debug.Log("Player attacked enemy");
        }
    }
}
