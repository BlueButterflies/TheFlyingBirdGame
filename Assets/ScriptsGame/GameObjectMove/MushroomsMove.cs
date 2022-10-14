using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomsMove : MonoBehaviour
{
    #region Variables 
    private bool mushroomAlreadyCounted = false;
    private AudioSource scoreAudio;
    #endregion

    #region Get components
    void Start()
    {
        scoreAudio = GetComponent<AudioSource>();
    }
    #endregion

    #region Move objects mushrooms
    void Update()
    {
        if (!GameController.gameOver)
        {
            transform.position = new Vector2(transform.position.x - 0.4f * Time.deltaTime, transform.position.y);
        }

        if (transform.position.x < -6)
        {
            Destroy(gameObject);
        }

        if (!mushroomAlreadyCounted && transform.position.x < -4)
        {
            scoreAudio.Play();
            mushroomAlreadyCounted = true;
            Score.score++;

        }
    }
    #endregion
}
