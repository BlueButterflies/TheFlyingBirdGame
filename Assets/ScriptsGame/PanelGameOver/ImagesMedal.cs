using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagesMedal : MonoBehaviour
{
    #region Variables
    public Sprite normalMedal;
    public Sprite bronze;
    public Sprite silver;
    public Sprite gold;

    public Sprite sadFace;

    private  Image image;
    private Text wonTxt;
    #endregion

    #region Get components
    public void Start()
    {
        image = GetComponent<Image>();
        
        wonTxt  = GameObject.Find("Canvas/Panel/WonTxt").GetComponent<Text>();
    }
    #endregion

    #region Update 
    public void Update()
    {
        int gameScore = Score.score;

        if (gameScore > 0 && gameScore <= 20)
        {
            wonTxt.text = "You won medal";
            image.sprite = normalMedal;
        }
        else if (gameScore > 20 && gameScore <= 50)
        {
            wonTxt.text = "You won \n bronze medal!";
            image.sprite = bronze;
        }
        else if (gameScore > 50 && gameScore <= 90)
        {
            wonTxt.text = "You won \n silver medal!";
            image.sprite = silver;
        }
        else if (gameScore > 90)
        {
            wonTxt.text = "You won \n gold medal!";
            image.sprite = gold;
        }
        else
        {
            wonTxt.text = "Sorry you didn't\n win medal!";

            image.sprite = sadFace;
        }
    }
    #endregion
}
