using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    #region Pause game
    public void OnPauseGame()
    {
        
        if (GameController.pause == false)
        {  
            GameController.gameOver = true;
            Time.timeScale = 0;
            GameController.pause = true;
        }
        else
        {
            GameController.gameOver = false;
            Time.timeScale = 1;
            GameController.pause = false;
        }
    }
    #endregion
}
