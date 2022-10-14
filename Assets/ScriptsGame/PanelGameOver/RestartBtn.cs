using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartBtn : MonoBehaviour
{
    public void Restart()
    {
        GameController.gameOver = false;
        SceneManager.LoadScene(1);
    }
}
