using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jump: MonoBehaviour
{
    public Rigidbody2D rigidBird;
    public float jumpBoost;
    public AudioSource jumpSound;
    public Score scoreText;
    public GameObject ReplayBtn;
    public AudioSource lostSound;


    void Start()
    {
        Time.timeScale = 1;
        ReplayBtn.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 jump = new Vector2(0.0f, jumpBoost);
            rigidBird.AddForce(jump);
            jumpSound.Play();
        }
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Cactus"))
        {
            lostSound.Play();
            ReplayGame();    
            ReplayBtn.SetActive(true);
        }
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
