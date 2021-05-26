using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public static bool playerHasDied = false;



    // Update is called once per frame
    void Update()
    {


        //if (GetComponent<PlayerHealth>().isAlive == false)
        //{
        //    playerHasDied = true;
        //    Debug.Log("=====================DEATH MENU ACTIVATED============");

        //}

        //if (playerHasDied == true)
        //{
        //    SceneManager.LoadScene("DeathScene");
        //    Time.timeScale = 0f;
        //}
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void TryAgain()
    {
        Debug.Log("BUTTON PRESSED");
        Time.timeScale = 1f;
        playerHasDied = false;
        SceneManager.LoadScene("GavinTestScene");
    }
}
