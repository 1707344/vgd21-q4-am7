using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject tutorialUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Resume();
            }
        }
    }

    void Pause()
    {
        tutorialUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume()
    {
        tutorialUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}