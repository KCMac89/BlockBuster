using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{

    public static bool gameIsPaused;

  
    void PauseGame()
    {
        gameIsPaused = true;

        if (gameIsPaused)
        {

            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1;
        }
       
    }
}
