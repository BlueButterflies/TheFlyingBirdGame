using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenuBtn : MonoBehaviour
{
    public void MainMenu()
    {
        GameController.gameOver = false;
        SceneManager.LoadScene(0);
    }
}
