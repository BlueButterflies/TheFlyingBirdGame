using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
    #region Variables
    public Color day;
    public Color night;
    public Color dark;
    #endregion

    #region Change background color
    void Start()
    {
        if (DateTime.Now.Hour >= 06 && DateTime.Now.Hour < 19)
        {
            Camera.main.backgroundColor = day;
        }
        else if(DateTime.Now.Hour >= 19 && DateTime.Now.Hour < 22)
        {
            Camera.main.backgroundColor = night;
        }
        else 
        {
            Camera.main.backgroundColor = dark;
        }
    }
    #endregion
}
