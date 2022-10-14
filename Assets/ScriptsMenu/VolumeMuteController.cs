using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeMuteController : MonoBehaviour
{
    #region Variables
    public static bool isMute;
    #endregion

    #region Attivate and disattivate sound game
    void Start()
    {
        isMute = PlayerPrefs.GetInt("MUTED") == 1;

        AudioListener.pause = isMute;
    }

    public void MutePressed()
    {
        isMute = !isMute;

        AudioListener.pause = isMute;
        PlayerPrefs.SetInt("MUTED", isMute ? 1 : 0);
    }
    #endregion
}
