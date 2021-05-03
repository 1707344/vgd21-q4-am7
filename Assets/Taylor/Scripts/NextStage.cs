using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStage : MonoBehaviour
{
    public GameObject arrow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            arrow.SetActive(true);
            Next();
        }
    }

    public void Next()
    {
        Destroy(gameObject);
    }
}
