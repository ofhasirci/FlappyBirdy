using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // GameController object is singleton
    public static GameController instance;

    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    public Text scoreText;

    public SoundManager soundManager;

    private int score = 0;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }

        soundManager = GetComponent<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // when game over restart the scene 
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void BirdyScored()
    {
        if (gameOver) return;
        score++;
        scoreText.text = "Score: " + score.ToString();
        soundManager.ScoreSound();
    }

    public void BirdyDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
        soundManager.DieSound();
    }
}
