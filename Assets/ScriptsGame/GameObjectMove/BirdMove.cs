using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    #region Variables
    private Rigidbody2D rb;
    private Animator animator;

    public GameObject panelGameOver;
    public GameObject scoreTxt;
    public GameObject bird;

    private AudioSource audioSource;
    #endregion

    #region Get components
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

    }
    #endregion

    #region Move bird with mouse 
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !GameController.gameOver)
        {
            audioSource.Play();

            rb.velocity = new Vector2(0f, 5.4f);
            animator.SetBool("ClickedBird", true);
        }
        else
        {
            animator.SetBool("ClickedBird", false);
        }
    }
    #endregion

    #region Collision bird
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.gameOver = true;
        GameController.pause = true;

        panelGameOver.SetActive(true);
        bird.SetActive(false);
        scoreTxt.SetActive(false);
    }
    #endregion
}
