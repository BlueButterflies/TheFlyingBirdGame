
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class GameController : MonoBehaviour
{
    #region Variables
    private float spawnTimer;
    private float spawnRate = 10f;
    public static bool gameOver;
    public static bool pause;

    public GameObject trunk;
    public GameObject mushroom;
    public GameObject stone;
    #endregion

    #region Charge objects
    void Update()
    {

        if (!GameController.gameOver)
        {
            spawnTimer += Time.deltaTime;

            if (spawnTimer >= spawnRate)
            {
                spawnTimer -= spawnRate;

                if (Score.score <= 20)
                {
                    Vector2 spawnPos = new Vector2(2f, Random.Range(-1f, 2f));

                    Instantiate(trunk, spawnPos, Quaternion.identity);
                    
                }
                else if (Score.score > 20 && Score.score <= 50)
                {
                    Vector2 spawnPos = new Vector2(2f, Random.Range(-1f, 2f));

                    Instantiate(mushroom, spawnPos, Quaternion.identity);
                }
                else if (Score.score > 50 && Score.score <= 90)
                {
                    Vector2 spawnPos = new Vector2(2f, Random.Range(-1f, 2f));

                    Instantiate(stone, spawnPos, Quaternion.identity);
                }

            }
        }
    }
    #endregion
}
