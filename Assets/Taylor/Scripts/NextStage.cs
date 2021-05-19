using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStage : MonoBehaviour
{
    public static int killCount = 0;

    public GameObject proceedUI;
    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
    public GameObject spawner4;
    public GameObject gameMaster;


    // Update is called once per frame
    void Update()
    {

        if (killCount >= 5)
        {
            Next1();
        }

    }

    public void Reset()
    {
        killCount = 0;
        proceedUI.SetActive(false);
        gameMaster.GetComponent<StageControl>().canContinue = false;
    }

    public void Next1()
    {
        Destroy(spawner1);
        proceedUI.SetActive(true);
        spawner2.SetActive(true);
        gameMaster.GetComponent<StageControl>().canContinue = true;
    }

    public void Next2()
    {
        Destroy(spawner2);
        proceedUI.SetActive(true);
        gameMaster.GetComponent<StageControl>().canContinue = true;
    }
}