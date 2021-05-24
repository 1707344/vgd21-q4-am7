using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStage : MonoBehaviour
{
    public static int killCount = 0;

    public GameObject proceedUI;
    public GameObject rightWall;
    public GameObject spawner;
    public GameObject gameMaster;


    // Update is called once per frame
    void Update()
    {

        if (killCount >= 3)
        {
            Next();
        }
    }

    public void Reset(float markerXPos)
    {
        killCount = 0;
        proceedUI.SetActive(false);
        gameMaster.GetComponent<StageControl>().canContinue = false;
        gameMaster.GetComponent<EnemySpawn>().canSpawn = true;
        gameMaster.transform.position = new Vector3(markerXPos, gameMaster.transform.position.y, 0);
    }

    public void Next()
    {
        proceedUI.SetActive(true);
        gameMaster.GetComponent<StageControl>().canContinue = true;
        gameMaster.GetComponent<EnemySpawn>().canSpawn = false;
    }
}