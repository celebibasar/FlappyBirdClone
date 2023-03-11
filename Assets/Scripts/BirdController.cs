using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class BirdController : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody2D rb;

    private int score;
    AudioSource audioSource;
    public TextMeshProUGUI scoreText;
    

    public GameObject gameOverPanel;
    private void Awake()
    {
        gameOverPanel.SetActive(false);
    }

    private void Start()
    {
        Time.timeScale = 1;
        audioSource = GetComponent<AudioSource>();

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Score"))
        {
            score++;
            scoreText.text = score.ToString();
            audioSource.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);

    }
}
