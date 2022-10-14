using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.UI.Button;

public class ControllerMenu : MonoBehaviour
{
    #region Variables
    public GameObject panelOptions;
    public GameObject buttonOptions;
    public GameObject buttonStart;
    public GameObject buttonExit;
    public GameObject txtNameGame;

    AudioSource audioSource;
    #endregion

    public void Start()
    {
        panelOptions.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    #region Main Menu
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Options()
    {
        panelOptions.SetActive(true);

        #region Deactivate buttons from Main Menu
        buttonOptions.SetActive(false);
        buttonStart.SetActive(false);
        txtNameGame.SetActive(false);
        buttonExit.SetActive(false);
        #endregion
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    #endregion

    #region Option Panel Fuctions
    public void BackBtn()
    {
        SceneManager.LoadScene(0);
    }
    #endregion
}
