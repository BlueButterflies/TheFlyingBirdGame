using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    private Vector2 positionInitial;


    void Start()
    {
        positionInitial = transform.position;
    }

    #region Move ground
    void Update()
    {
        if (!GameController.gameOver)
        {
            if (transform.position.x >= -7.3f)
            {
                 transform.position = new Vector2(transform.position.x - 0.4f * Time.deltaTime, transform.position.y);
            }
            else
            {
                 transform.position = positionInitial;
            }
        }
    }
    #endregion
}
