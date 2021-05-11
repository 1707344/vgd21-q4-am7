using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStage : MonoBehaviour
{
    public static int killCount = 0;

    public GameObject proceedUI;
    public GameObject rightWall;
    public GameObject spawner;


    // Update is called once per frame
    void Update()
    {

        if (killCount >= 5)
        {
            Debug.Log(killCount);

            Next();
        }
    }

    public void Next()
    {
        proceedUI.SetActive(true);
        Destroy(rightWall);
        Destroy(spawner);
    }
}
